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
    public partial class Dialog_Run_File : Form
    {
        public static string[] Data_Loaded_File = new string[3];
        //public static string Hide_Run;

        public Dialog_Run_File()
        {
            InitializeComponent();
            Data_Loaded_File[1] = "0";
        }

        private void Open_Dialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.Filter = "All Files| *.*";
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                string[] filename = OpenFile.FileName.Split('.');
                Data_Loaded_File[2] = filename[1];
                Path_textbox.Text = OpenFile.FileName;
            }
        }

        private void Set_Click(object sender, EventArgs e)
        {
            if (Path_textbox != null)
            {
                if (Hide_Run_check.Checked == true)
                {
                    Data_Loaded_File[1] = "1";
                }

                Data_Loaded_File[0] = Path_textbox.Text;
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
