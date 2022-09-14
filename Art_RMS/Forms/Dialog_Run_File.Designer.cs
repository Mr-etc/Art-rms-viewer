namespace Art_RMS.Forms
{
    partial class Dialog_Run_File
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
            this.Set_btn = new System.Windows.Forms.Button();
            this.Open_Dialog_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Path_textbox = new System.Windows.Forms.TextBox();
            this.Hide_Run_check = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Set_btn
            // 
            this.Set_btn.Location = new System.Drawing.Point(436, 76);
            this.Set_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Set_btn.Name = "Set_btn";
            this.Set_btn.Size = new System.Drawing.Size(100, 28);
            this.Set_btn.TabIndex = 7;
            this.Set_btn.Text = "Set";
            this.Set_btn.UseVisualStyleBackColor = true;
            this.Set_btn.Click += new System.EventHandler(this.Set_Click);
            // 
            // Open_Dialog_btn
            // 
            this.Open_Dialog_btn.Location = new System.Drawing.Point(436, 22);
            this.Open_Dialog_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Open_Dialog_btn.Name = "Open_Dialog_btn";
            this.Open_Dialog_btn.Size = new System.Drawing.Size(100, 28);
            this.Open_Dialog_btn.TabIndex = 6;
            this.Open_Dialog_btn.Text = "Open Dialog";
            this.Open_Dialog_btn.UseVisualStyleBackColor = true;
            this.Open_Dialog_btn.Click += new System.EventHandler(this.Open_Dialog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Path:";
            // 
            // Path_textbox
            // 
            this.Path_textbox.Location = new System.Drawing.Point(16, 25);
            this.Path_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.Path_textbox.Name = "Path_textbox";
            this.Path_textbox.Size = new System.Drawing.Size(407, 22);
            this.Path_textbox.TabIndex = 4;
            // 
            // Hide_Run_check
            // 
            this.Hide_Run_check.AutoSize = true;
            this.Hide_Run_check.Location = new System.Drawing.Point(16, 62);
            this.Hide_Run_check.Margin = new System.Windows.Forms.Padding(4);
            this.Hide_Run_check.Name = "Hide_Run_check";
            this.Hide_Run_check.Size = new System.Drawing.Size(145, 21);
            this.Hide_Run_check.TabIndex = 8;
            this.Hide_Run_check.Text = "Скрытный запуск";
            this.Hide_Run_check.UseVisualStyleBackColor = true;
            // 
            // Dialog_Run_File
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 112);
            this.Controls.Add(this.Hide_Run_check);
            this.Controls.Add(this.Set_btn);
            this.Controls.Add(this.Open_Dialog_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Path_textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Dialog_Run_File";
            this.Text = "Dialog_Run_File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Set_btn;
        private System.Windows.Forms.Button Open_Dialog_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Path_textbox;
        private System.Windows.Forms.CheckBox Hide_Run_check;
    }
}