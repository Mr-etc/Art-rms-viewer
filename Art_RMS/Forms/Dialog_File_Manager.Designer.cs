namespace Art_RMS.Forms
{
    partial class Dialog_File_Manager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dialog_File_Manager));
            this.lblPath = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.Directory_List = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.To_Back_Btn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refrashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secretlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(9, 20);
            this.lblPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(94, 17);
            this.lblPath.TabIndex = 6;
            this.lblPath.Text = "Remote Path:";
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPath.Location = new System.Drawing.Point(117, 15);
            this.txtPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(378, 22);
            this.txtPath.TabIndex = 5;
            // 
            // Directory_List
            // 
            this.Directory_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Directory_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3});
            this.Directory_List.FullRowSelect = true;
            this.Directory_List.GridLines = true;
            this.Directory_List.Location = new System.Drawing.Point(13, 47);
            this.Directory_List.Margin = new System.Windows.Forms.Padding(4);
            this.Directory_List.MultiSelect = false;
            this.Directory_List.Name = "Directory_List";
            this.Directory_List.Size = new System.Drawing.Size(520, 345);
            this.Directory_List.TabIndex = 7;
            this.Directory_List.UseCompatibleStateImageBehavior = false;
            this.Directory_List.View = System.Windows.Forms.View.Details;
            this.Directory_List.DoubleClick += new System.EventHandler(this.Double_Click_In_Dir);
            this.Directory_List.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Open_Context_Menu);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Size";
            this.columnHeader3.Width = 150;
            // 
            // To_Back_Btn
            // 
            this.To_Back_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.To_Back_Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("To_Back_Btn.BackgroundImage")));
            this.To_Back_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.To_Back_Btn.Location = new System.Drawing.Point(501, 14);
            this.To_Back_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.To_Back_Btn.Name = "To_Back_Btn";
            this.To_Back_Btn.Size = new System.Drawing.Size(33, 28);
            this.To_Back_Btn.TabIndex = 8;
            this.To_Back_Btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.To_Back_Btn.UseVisualStyleBackColor = true;
            this.To_Back_Btn.Click += new System.EventHandler(this.To_Back_Btn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refrashToolStripMenuItem,
            this.runToolStripMenuItem,
            this.downloadToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(148, 100);
            // 
            // refrashToolStripMenuItem
            // 
            this.refrashToolStripMenuItem.Name = "refrashToolStripMenuItem";
            this.refrashToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.refrashToolStripMenuItem.Text = "Refresh";
            this.refrashToolStripMenuItem.Click += new System.EventHandler(this.Refresh_dir_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalToolStripMenuItem,
            this.secretlyToolStripMenuItem});
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.runToolStripMenuItem.Text = "Run";
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.Run_Click);
            // 
            // secretlyToolStripMenuItem
            // 
            this.secretlyToolStripMenuItem.Name = "secretlyToolStripMenuItem";
            this.secretlyToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.secretlyToolStripMenuItem.Text = "Secretly";
            this.secretlyToolStripMenuItem.Click += new System.EventHandler(this.Run_Click);
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.downloadToolStripMenuItem.Text = "Download";
            this.downloadToolStripMenuItem.Click += new System.EventHandler(this.Download_File_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Dialog_File_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 407);
            this.Controls.Add(this.To_Back_Btn);
            this.Controls.Add(this.Directory_List);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.txtPath);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dialog_File_Manager";
            this.Text = "Dialog_File_Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dialog_File_Manager_FormClosing);
            this.Load += new System.EventHandler(this.Dialog_File_Manager_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.ListView Directory_List;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button To_Back_Btn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secretlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refrashToolStripMenuItem;
    }
}