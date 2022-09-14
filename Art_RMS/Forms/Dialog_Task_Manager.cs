using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;

namespace Art_RMS.Forms
{
    public partial class Dialog_Task_Manager : Form
    {
        Listener server = new Listener();
        public Dialog_Task_Manager()
        {
            InitializeComponent();
        }
        public void Fill_Table(List<Array> Response)
        {
            Invoke(new ThreadStart(() =>
            {
                ListViewItem Item;
                Task_List.Items.Clear();
                for (int i = 1; i < (Response.Count - 1); i++)
                {
                    string[] Row = Encoding.UTF8.GetString((byte[])Response[i]).Split(':');
                    if (Row[2] == "")
                        Item = new ListViewItem(new string[] { Row[0], Row[1], "None" });
                    else
                        Item = new ListViewItem(new string[] { Row[0], Row[1], Row[2]});
                    Task_List.Items.Add(Item);
                }
            }));

        } //Заполнение таблицы

        private void Dialog_Task_Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach(Form frm in Listener.Forms)
            {
                if (frm.Tag == this.Tag && frm.Text.Contains("Dialog_Task_Manager"))
                {
                    Listener.Forms.Remove(frm);
                    break;
                }
            }
        }

        #region Function Menu

        private void Refresh_Task_List_Click(object sender, EventArgs e)
        {
            server.Send(Convert.ToInt32(this.Tag), "GET_TASK_LIST|");
        } // Обновить Task List

        private void Kill_Process_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in Task_List.SelectedItems)
            {
                server.Send(Convert.ToInt32(this.Tag), "KILL_PROCESS|" + Task_List.Items[item.Index].SubItems[0].Text);
            }
            Thread.Sleep(1000);
            Refresh_Task_List_Click(null, null);
        } // Send Kill Process

        private void Block_Process_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in Task_List.SelectedItems)
            {
                if(contextMenuStrip1.Items[2].Text == "Block Process")
                    server.Send(Convert.ToInt32(this.Tag), "BLOCK_PROCESS|" + Task_List.Items[item.Index].SubItems[1].Text);
                else
                    server.Send(Convert.ToInt32(this.Tag), "UNLOCK_PROCESS|" + Task_List.Items[item.Index].SubItems[1].Text);
            }
        } //Block Process and Unlock Process


        #endregion

        private void Open_context_menu(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(MousePosition);
            }
        }

        private void Blocked_Process_Show_Click(object sender, EventArgs e)
        {
            server.Send(Convert.ToInt32(this.Tag), "GET_BLOCKED_PROCESSES|");
            contextMenuStrip1.Items[1].Enabled = false;
            contextMenuStrip1.Items[2].Text = "Unlock Process";
        }

        private void Dialog_Task_Manager_Load(object sender, EventArgs e)
        {
            server.Send(Convert.ToInt32(this.Tag), "GET_TASK_LIST|");
        }

        private void Task_List_Show_Clisck(object sender, EventArgs e)
        {
            server.Send(Convert.ToInt32(this.Tag), "GET_TASK_LIST|");
            contextMenuStrip1.Items[1].Enabled = true;
            contextMenuStrip1.Items[2].Text = "Block Process";
        }
    }
}
