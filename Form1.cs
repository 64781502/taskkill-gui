using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace taskkill_gui
{
    public partial class GUIForm : Form
    {
        public GUIForm()
        {
            InitializeComponent();
        }

        Point lastPoint;

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", @"/c taskkill /PID " + PIDBox.Text);
        }

        private void SendButtonIM_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.EndsWith(".exe"))
            {
                Process.Start("cmd.exe", @"/c taskkill /IM " + textBox1.Text);
            }
            else
            {
                Process.Start("cmd.exe", @"/c taskkill /IM " + textBox1.Text + ".exe");
            }
        }

        private void OpenTM_Click(object sender, EventArgs e)
        {
            Process.Start("taskmgr");
        }

        private void GUIForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(900, 500);
            int ProcID = Process.GetProcessesByName("taskkill_gui")[0].Id;
            LogoText.Text = "taskkill gui (" + ProcID.ToString() + ")";
        }

        private void HelpButton2_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1400, 500);
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/c tasklist | sort /R /+58"; //tasklist
            process.StartInfo = startInfo;
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            TextBoxOut.Text = output.Remove(output.Length - 3);
            process.WaitForExit();
        }
    }
}
