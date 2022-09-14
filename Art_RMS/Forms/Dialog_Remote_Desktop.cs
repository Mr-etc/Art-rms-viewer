using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace Art_RMS.Forms
{
    public partial class Dialog_Remote_Desktop : Form
    {
        Listener TCP_server = new Listener();
        private string delay = "5";
        private string _delay
        {
            get { return delay; }
            set
            {
                string res = Regex.Match(value, @"(^\d+$)").Groups[0].Value;
                if (!String.IsNullOrWhiteSpace(res))
                {
                    delay = res;
                }
                delay_textbox.Text = delay;
            }
        }


        public Dialog_Remote_Desktop()
        {
            InitializeComponent();
        }

        private void Start_Listen(object sender, EventArgs e)
        {
            if (startToolStripMenuItem.Text == "Start")
            {
                startToolStripMenuItem.Text = "Stop";
                TCP_server.Send(Convert.ToInt32(this.Tag), $"START_REMOTE_DESKTOP|{_delay}000|");
            }
            else
            {
                TCP_server.Send(Convert.ToInt32(this.Tag), "STOP_REMOTE_DESKTOP|");
                startToolStripMenuItem.Text = "Start";
            }
        }

        public void Response(byte[] Response)
        {
            try
            {
                Invoke(new ThreadStart(() => {
                        MemoryStream ms = new MemoryStream(Response);
                        Picture_Desktop.BackgroundImage = Image.FromStream(ms);
                }));
            }
            catch { }
        }

        private void Dialog_Remote_Desktop_FormClosing(object sender, FormClosingEventArgs e)
        {

            Remove();
            if (startToolStripMenuItem.Text == "Stop")
                TCP_server.Send(Convert.ToInt32(this.Tag), "STOP_REMOTE_DESKTOP|");
        }

        private void Remove()
        {
            foreach (Form frm in Listener.Forms)
            {
                if (frm.Tag == this.Tag && frm.Text.Contains("Dialog_Remote_Desktop"))
                {
                    Listener.Forms.Remove(frm);
                    break;
                }
            }
        }
        private void Set_Delay_Click(object sender, EventArgs e)
        {
            _delay = delay_textbox.Text;
        }
    }
}
