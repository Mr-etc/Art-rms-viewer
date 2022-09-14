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
    public partial class Dialog_Open_URL : Form
    {
        public static string URL;
        public Dialog_Open_URL()
        {
            InitializeComponent();
        }

        private void OK_btn_Click(object sender, EventArgs e)
        {
            if (Textbox_URL.Text.Contains("http://") || Textbox_URL.Text.Contains("https://"))
            {
                DialogResult = DialogResult.OK;
                URL = Textbox_URL.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный формат ссылки!");
            }
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
