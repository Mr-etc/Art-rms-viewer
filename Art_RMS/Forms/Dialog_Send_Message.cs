using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Art_RMS.Forms
{
    public partial class Dialog_Send_Message : Form
    {
        public static string Msg;
        public Dialog_Send_Message()
        {
            InitializeComponent();
        }

        private void OK_btn_Click(object sender, EventArgs e)
        {
            if (Textbox_Message.Text != "")
            {
                Msg = Textbox_Message.Text;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля!", "Dialog_Send_Message");
            }
        }

        private void Cencel_btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
