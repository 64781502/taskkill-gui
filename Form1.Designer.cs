namespace taskkill_gui
{
    partial class GUIForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIForm));
            this.PIDBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LogoText = new System.Windows.Forms.Label();
            this.SendButtonIM = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OpenTM = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HelpButton2 = new System.Windows.Forms.Button();
            this.TextBoxOut = new System.Windows.Forms.TextBox();
            this.RamSize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PIDBox
            // 
            this.PIDBox.BackColor = System.Drawing.Color.DimGray;
            this.PIDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PIDBox.ForeColor = System.Drawing.Color.White;
            this.PIDBox.Location = new System.Drawing.Point(233, 281);
            this.PIDBox.MaxLength = 7;
            this.PIDBox.Name = "PIDBox";
            this.PIDBox.Size = new System.Drawing.Size(94, 31);
            this.PIDBox.TabIndex = 1;
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.DimGray;
            this.SendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SendButton.ForeColor = System.Drawing.Color.White;
            this.SendButton.Location = new System.Drawing.Point(248, 318);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(61, 28);
            this.SendButton.TabIndex = 2;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(221, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "process identifier (PID)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogoText
            // 
            this.LogoText.BackColor = System.Drawing.Color.Transparent;
            this.LogoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogoText.ForeColor = System.Drawing.Color.White;
            this.LogoText.Location = new System.Drawing.Point(281, 29);
            this.LogoText.Name = "LogoText";
            this.LogoText.Size = new System.Drawing.Size(282, 43);
            this.LogoText.TabIndex = 4;
            this.LogoText.Text = "taskkill gui";
            this.LogoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SendButtonIM
            // 
            this.SendButtonIM.BackColor = System.Drawing.Color.DimGray;
            this.SendButtonIM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SendButtonIM.ForeColor = System.Drawing.Color.White;
            this.SendButtonIM.Location = new System.Drawing.Point(544, 318);
            this.SendButtonIM.Name = "SendButtonIM";
            this.SendButtonIM.Size = new System.Drawing.Size(61, 28);
            this.SendButtonIM.TabIndex = 6;
            this.SendButtonIM.Text = "Send";
            this.SendButtonIM.UseVisualStyleBackColor = false;
            this.SendButtonIM.Click += new System.EventHandler(this.SendButtonIM_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DimGray;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(505, 281);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 31);
            this.textBox1.TabIndex = 5;
            // 
            // OpenTM
            // 
            this.OpenTM.BackColor = System.Drawing.Color.DimGray;
            this.OpenTM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OpenTM.ForeColor = System.Drawing.Color.White;
            this.OpenTM.Location = new System.Drawing.Point(12, 421);
            this.OpenTM.Name = "OpenTM";
            this.OpenTM.Size = new System.Drawing.Size(43, 28);
            this.OpenTM.TabIndex = 8;
            this.OpenTM.Text = "help";
            this.OpenTM.UseVisualStyleBackColor = false;
            this.OpenTM.Click += new System.EventHandler(this.OpenTM_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(356, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "taskkill with";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(505, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "image name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HelpButton2
            // 
            this.HelpButton2.BackColor = System.Drawing.Color.DimGray;
            this.HelpButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HelpButton2.ForeColor = System.Drawing.Color.White;
            this.HelpButton2.Location = new System.Drawing.Point(61, 421);
            this.HelpButton2.Name = "HelpButton2";
            this.HelpButton2.Size = new System.Drawing.Size(55, 28);
            this.HelpButton2.TabIndex = 11;
            this.HelpButton2.Text = "help 2";
            this.HelpButton2.UseVisualStyleBackColor = false;
            this.HelpButton2.Click += new System.EventHandler(this.HelpButton2_Click);
            // 
            // TextBoxOut
            // 
            this.TextBoxOut.BackColor = System.Drawing.Color.DimGray;
            this.TextBoxOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxOut.Cursor = System.Windows.Forms.Cursors.Help;
            this.TextBoxOut.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxOut.ForeColor = System.Drawing.Color.White;
            this.TextBoxOut.Location = new System.Drawing.Point(885, 3);
            this.TextBoxOut.Multiline = true;
            this.TextBoxOut.Name = "TextBoxOut";
            this.TextBoxOut.ReadOnly = true;
            this.TextBoxOut.Size = new System.Drawing.Size(496, 455);
            this.TextBoxOut.TabIndex = 13;
            this.TextBoxOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RamSize
            // 
            this.RamSize.AutoSize = true;
            this.RamSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RamSize.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RamSize.Location = new System.Drawing.Point(7, 9);
            this.RamSize.Name = "RamSize";
            this.RamSize.Size = new System.Drawing.Size(0, 25);
            this.RamSize.TabIndex = 14;
            // 
            // GUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1384, 461);
            this.Controls.Add(this.RamSize);
            this.Controls.Add(this.TextBoxOut);
            this.Controls.Add(this.HelpButton2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OpenTM);
            this.Controls.Add(this.SendButtonIM);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LogoText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.PIDBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GUIForm";
            this.Text = "taskkill";
            this.Load += new System.EventHandler(this.GUIForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PIDBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LogoText;
        private System.Windows.Forms.Button SendButtonIM;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button OpenTM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button HelpButton2;
        private System.Windows.Forms.TextBox TextBoxOut;
        private System.Windows.Forms.Label RamSize;
    }
}

