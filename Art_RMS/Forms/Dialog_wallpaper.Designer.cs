namespace Art_RMS.Forms
{
    partial class Dialog_wallpaper
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
            this.Path_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Open_Dialog_btn = new System.Windows.Forms.Button();
            this.Set_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Path_textbox
            // 
            this.Path_textbox.Location = new System.Drawing.Point(16, 22);
            this.Path_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.Path_textbox.Name = "Path_textbox";
            this.Path_textbox.Size = new System.Drawing.Size(407, 22);
            this.Path_textbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path:";
            // 
            // Open_Dialog_btn
            // 
            this.Open_Dialog_btn.Location = new System.Drawing.Point(436, 20);
            this.Open_Dialog_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Open_Dialog_btn.Name = "Open_Dialog_btn";
            this.Open_Dialog_btn.Size = new System.Drawing.Size(100, 28);
            this.Open_Dialog_btn.TabIndex = 2;
            this.Open_Dialog_btn.Text = "Open Dialog";
            this.Open_Dialog_btn.UseVisualStyleBackColor = true;
            this.Open_Dialog_btn.Click += new System.EventHandler(this.Open_Dialog_Click);
            // 
            // Set_btn
            // 
            this.Set_btn.Location = new System.Drawing.Point(436, 74);
            this.Set_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Set_btn.Name = "Set_btn";
            this.Set_btn.Size = new System.Drawing.Size(100, 28);
            this.Set_btn.TabIndex = 3;
            this.Set_btn.Text = "Set";
            this.Set_btn.UseVisualStyleBackColor = true;
            this.Set_btn.Click += new System.EventHandler(this.Set_btn_Click);
            // 
            // Dialog_wallpaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 112);
            this.Controls.Add(this.Set_btn);
            this.Controls.Add(this.Open_Dialog_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Path_textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dialog_wallpaper";
            this.Text = "Dialog_wallpaper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Path_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Open_Dialog_btn;
        private System.Windows.Forms.Button Set_btn;
    }
}