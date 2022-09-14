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
    public partial class Dialog_wallpaper : Form
    {
        public static string path;
        public Dialog_wallpaper()
        {
            InitializeComponent();
        }

        private void Open_Dialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.Filter = "JPG|*.jpg";
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                Path_textbox.Text = OpenFile.FileName;
            }
        }

        private void Set_btn_Click(object sender, EventArgs e)
        {
            if (path != "")
            {
                path = Path_textbox.Text;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }
    }
}
