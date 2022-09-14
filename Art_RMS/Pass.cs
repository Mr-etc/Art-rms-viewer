using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Art_RMS
{
    public partial class Pass : Form
    {
        public Pass()
        {
            InitializeComponent();
        }
        const string pass = "0cbc6611f5540bd0809a388dc95a615b"; //Pass is: Test
        private void Ok_btn_Click(object sender, EventArgs e)
        {
            using (var md5 = MD5.Create())
            {
                if (BitConverter.ToString(md5.ComputeHash(Encoding.UTF8.GetBytes(Password_text.Text))).Replace("-", String.Empty) == pass.ToUpper())
                    this.DialogResult = DialogResult.OK;
                else
                {
                    MessageBox.Show("Incorrect password!");
                    Password_text.Text = "";
                }            
            }
        }

        private void Password_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Ok_btn_Click(null, null);
        }
    }
}
