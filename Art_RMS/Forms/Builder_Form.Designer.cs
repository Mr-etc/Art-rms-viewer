namespace Art_RMS.Forms
{
    partial class Builder_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.autorun_check = new System.Windows.Forms.CheckBox();
            this.dns_textbox = new System.Windows.Forms.TextBox();
            this.port_textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Port:";
            // 
            // autorun_check
            // 
            this.autorun_check.AutoSize = true;
            this.autorun_check.Location = new System.Drawing.Point(16, 95);
            this.autorun_check.Name = "autorun_check";
            this.autorun_check.Size = new System.Drawing.Size(85, 21);
            this.autorun_check.TabIndex = 1;
            this.autorun_check.Text = "AutoRun";
            this.autorun_check.UseVisualStyleBackColor = true;
            // 
            // dns_textbox
            // 
            this.dns_textbox.Location = new System.Drawing.Point(63, 26);
            this.dns_textbox.Name = "dns_textbox";
            this.dns_textbox.Size = new System.Drawing.Size(148, 22);
            this.dns_textbox.TabIndex = 2;
            // 
            // port_textbox
            // 
            this.port_textbox.Location = new System.Drawing.Point(63, 59);
            this.port_textbox.Name = "port_textbox";
            this.port_textbox.Size = new System.Drawing.Size(148, 22);
            this.port_textbox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Build";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Build_Click);
            // 
            // Builder_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 172);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.port_textbox);
            this.Controls.Add(this.dns_textbox);
            this.Controls.Add(this.autorun_check);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Builder_Form";
            this.Text = "Builder_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox autorun_check;
        private System.Windows.Forms.TextBox dns_textbox;
        private System.Windows.Forms.TextBox port_textbox;
        private System.Windows.Forms.Button button1;
    }
}