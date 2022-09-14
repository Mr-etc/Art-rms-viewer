namespace Art_RMS.Forms
{
    partial class Dialog_Task_Manager
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
            this.Task_List = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refrashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.killProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blockProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blockedProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Task_List
            // 
            this.Task_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Task_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.Task_List.FullRowSelect = true;
            this.Task_List.GridLines = true;
            this.Task_List.Location = new System.Drawing.Point(0, 33);
            this.Task_List.Margin = new System.Windows.Forms.Padding(4);
            this.Task_List.Name = "Task_List";
            this.Task_List.Size = new System.Drawing.Size(493, 349);
            this.Task_List.TabIndex = 1;
            this.Task_List.UseCompatibleStateImageBehavior = false;
            this.Task_List.View = System.Windows.Forms.View.Details;
            this.Task_List.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Open_context_menu);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "PID";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Process Name";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tittle";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 120;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refrashToolStripMenuItem,
            this.killProcessToolStripMenuItem,
            this.blockProcessToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(168, 76);
            // 
            // refrashToolStripMenuItem
            // 
            this.refrashToolStripMenuItem.Name = "refrashToolStripMenuItem";
            this.refrashToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.refrashToolStripMenuItem.Text = "Refresh";
            this.refrashToolStripMenuItem.Click += new System.EventHandler(this.Refresh_Task_List_Click);
            // 
            // killProcessToolStripMenuItem
            // 
            this.killProcessToolStripMenuItem.Name = "killProcessToolStripMenuItem";
            this.killProcessToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.killProcessToolStripMenuItem.Text = "Kill Process";
            this.killProcessToolStripMenuItem.Click += new System.EventHandler(this.Kill_Process_Click);
            // 
            // blockProcessToolStripMenuItem
            // 
            this.blockProcessToolStripMenuItem.Name = "blockProcessToolStripMenuItem";
            this.blockProcessToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.blockProcessToolStripMenuItem.Text = "Block Process";
            this.blockProcessToolStripMenuItem.Click += new System.EventHandler(this.Block_Process_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(496, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taskListToolStripMenuItem,
            this.blockedProcessToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.настройкиToolStripMenuItem.Text = "File";
            // 
            // taskListToolStripMenuItem
            // 
            this.taskListToolStripMenuItem.Name = "taskListToolStripMenuItem";
            this.taskListToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.taskListToolStripMenuItem.Text = "Task List";
            this.taskListToolStripMenuItem.Click += new System.EventHandler(this.Task_List_Show_Clisck);
            // 
            // blockedProcessToolStripMenuItem
            // 
            this.blockedProcessToolStripMenuItem.Name = "blockedProcessToolStripMenuItem";
            this.blockedProcessToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.blockedProcessToolStripMenuItem.Text = "Blocked Processes";
            this.blockedProcessToolStripMenuItem.Click += new System.EventHandler(this.Blocked_Process_Show_Click);
            // 
            // Dialog_Task_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 382);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Task_List);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dialog_Task_Manager";
            this.Text = "Dialog_Task_Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dialog_Task_Manager_FormClosing);
            this.Load += new System.EventHandler(this.Dialog_Task_Manager_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView Task_List;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem killProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blockProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refrashToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blockedProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskListToolStripMenuItem;
    }
}