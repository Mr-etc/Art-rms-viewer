using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Art_RMS.Forms
{
    public partial class Dialog_cmd : Form
    {
        Listener TCP_server = new Listener();
        string App = "CMD";

        public Dialog_cmd()
        {
            InitializeComponent();
        }

        private void Start_Listen_Cmd(object sender, EventArgs e)
        {
            /*if (startToolStripMenuItem.Text == "Start")
            {
                startToolStripMenuItem.Text = "Stop";
                TCP_server.Send(Convert.ToInt32(this.Tag), $"REMOTE_COMMAND|{App}|");
            }
            else
            {
                TCP_server.Send(Convert.ToInt32(this.Tag), "STOP_REMOTE_COMMAND|");
                startToolStripMenuItem.Text = "Start";
            }*/
        }

        private void Set_App(object sender, EventArgs e)
        {
            switch((sender as ToolStripItem).Text)
            {
                case "Cmd":
                    App = "CMD";
                    break;
                case "PowerShell":
                    App = "POWERSHELL";
                    break;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TCP_server.Send(Convert.ToInt32(this.Tag), $"REMOTE_COMMAND|{App}|" + Command_text.Text);
                Cmd_Log.AppendText($"{Command_text.Text} \n");
                Command_text.Text = "";
            }
        }

        #region Received
        public void Received(string Result)
        {
            Invoke(new ThreadStart(() =>
            {
                Cmd_Log.AppendText($"{Result} \n");
            }));
        }
        #endregion
    }
}
