using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;

namespace Art_RMS.Forms
{
    public partial class Dialog_Chat : Form
    {
        public string Name_user;
        Listener server = new Listener();
        public Dialog_Chat()
        {
            InitializeComponent();
        }

        private void Send_btn_Click(object sender, EventArgs e)
        {
            Thread.Sleep(500);
            server.Send(Convert.ToInt32(this.Tag), "CHAT_FUNCTION|SEND_MESSAGE_CHAT|" + Textbox_Message.Text);
            Chat_Table.AppendText($"Вы: {Textbox_Message.Text} \n");
            Textbox_Message.Text = "";
        } // Send button

        #region Received
        public void Received(string Result)
        {
            Invoke(new ThreadStart(() =>
            {
                Chat_Table.AppendText($"{Name_user}: {Result} \n");
            }));
        }
        #endregion

        private void Dialog_Chat_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form frm in Listener.Forms)
            {
                if (frm.Tag == this.Tag && frm.Text == "Dialog_Chat")
                {
                    if (Listener.All_Clients[Convert.ToInt32(this.Tag)].Connected == true)
                        server.Send(Convert.ToInt32(this.Tag), "CHAT_FUNCTION|CLOSE_CHAT|");
                    Listener.Forms.Remove(frm);
                    break;
                }
            }
        }

        private void Load_Form(object sender, EventArgs e)
        {
            Chat_Table.AppendText($"Ваш собеседник: {Name_user}\n\n");
            server.Send(Convert.ToInt32(this.Tag), "OPEN_CHAT_CONNECT|");
        }

        private void Textbox_Message_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Send_btn_Click(null, null);
        }
    }
}
