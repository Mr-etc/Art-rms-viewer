using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Art_RMS.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Art_RMS
{
    public partial class Form1 : Form
    {
        Listener server = new Listener();
        Thread Listen;
        public Form1()
        {
            InitializeComponent();
            server.Recesived += Received;
        }

        private void Start_Listening_Click(object sender, EventArgs e)
        {
            startToolStripMenuItem.Enabled = false;
            Listen = new Thread(() =>
            {
                server.BeginListen();
            });
            Listen.IsBackground = true;
            Listen.Start();

        } //Start Listening

        void Received(int ID_User, byte[] data)
        {
            string first, second, third;
            List<Array> answer = Listener.GetMessage(data, 0);
            switch (Encoding.UTF8.GetString((byte[])answer[0]))
            {
                case "CONNECTION":
                    first = Encoding.UTF8.GetString((byte[])answer[1]);
                    second = Encoding.UTF8.GetString((byte[])answer[2]);
                    third = Encoding.UTF8.GetString((byte[])answer[3]);
                    Invoke(new _Add(Add), ID_User, first, second, third);
                    break;
                case "DELETE":
                    Invoke(new _Delete_User(Delete_User), ID_User);
                    break;
                case "STATUS":
                    first = Encoding.UTF8.GetString((byte[])answer[1]);
                    Invoke(new _ChangeStatus(ChangeStatus), ID_User, first);
                    break;
            }
        } //Обработка сообщения

        private void Open_context_menu(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(MousePosition);
            }
        } //Открытие контекстного меню

        /*========================*/
        #region Function from menu
        private void sendMessage_Click(object sender, EventArgs e)
        {
            Dialog_Send_Message Message_form = new Dialog_Send_Message();
            Message_form.ShowDialog();
            if (Message_form.DialogResult == DialogResult.OK)
            {
                string msg = Dialog_Send_Message.Msg;
                foreach (ListViewItem item in List_User.SelectedItems)
                {
                    int id = Convert.ToInt32(List_User.Items[item.Index].SubItems[0].Text);
                    server.Send(id, "MSGBOX|" + msg);
                }
            }
        } //Отправка сообщения

        private void sleepPC_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in List_User.SelectedItems)
            {
                int id = Convert.ToInt32(List_User.Items[item.Index].SubItems[0].Text);
                server.Send(id, "SLEEP_PC|");
            }
        }  //Включить у пользователя спящий режим

        private void logOutUser_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in List_User.SelectedItems)
            {
                int id = Convert.ToInt32(List_User.Items[item.Index].SubItems[0].Text);
                server.Send(id, "LOG_OUT_PC|");
            }
        } //Выйти из системы у пользователя

        private void Open_URL_Click(object sender, EventArgs e)
        {
            Dialog_Open_URL Form_URL = new Dialog_Open_URL();
            Form_URL.ShowDialog();
            if (Form_URL.DialogResult == DialogResult.OK)
            {
                foreach (ListViewItem item in List_User.SelectedItems)
                {
                    int id = Convert.ToInt32(List_User.Items[item.Index].SubItems[0].Text);
                    server.Send(id, "OPEN_URL|" + Dialog_Open_URL.URL);
                }
            }
        } //Открытие ссылки в браузере

        private void Disconnect_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in List_User.SelectedItems)
            {
                int id = Convert.ToInt32(List_User.Items[item.Index].SubItems[0].Text);
                server.Send(id, "DISCONNECT|");
            }
        }  //Отключиться от пользователя

        private void Change_Wallpaper_Click(object sender, EventArgs e)
        {
            int id;
            Dialog_wallpaper dialog_wallpaper = new Dialog_wallpaper();
            dialog_wallpaper.ShowDialog();
            if (dialog_wallpaper.DialogResult == DialogResult.OK)
            {
                byte[] file = File.ReadAllBytes(Dialog_wallpaper.path);
                foreach (ListViewItem item in List_User.SelectedItems)
                {
                    id = Convert.ToInt32(List_User.Items[item.Index].SubItems[0].Text);
                    server.Send(id, "CHANGE_WALLPAPER|", file);
                }
            }

        } // Смена картинки рабочего стола

        private void Run_File_Click(object sender, EventArgs e)
        {
            int id;
            Dialog_Run_File dialog_Run_File = new Dialog_Run_File();
            dialog_Run_File.ShowDialog();
            if (dialog_Run_File.DialogResult == DialogResult.OK)
            {
                byte[] file = File.ReadAllBytes(Dialog_Run_File.Data_Loaded_File[0]);
                foreach (ListViewItem item in List_User.SelectedItems)
                {
                    id = Convert.ToInt32(List_User.Items[item.Index].SubItems[0].Text);
                    server.Send(id, "RUN_FILE|"+ Dialog_Run_File.Data_Loaded_File[1] + "|"+ Dialog_Run_File.Data_Loaded_File[2] + "|", file);
                }
            }
        } //Удаленный запуск

        private void Open_Chat_Click(object sender, EventArgs e)
        {
            int id;
            string Name;
            foreach (ListViewItem item in List_User.SelectedItems)
            {
                id = Convert.ToInt32(List_User.Items[item.Index].SubItems[0].Text);
                Name = List_User.Items[item.Index].SubItems[1].Text;
                bool Check = false;
                foreach (Form Frm in Listener.Forms)
                {
                    if (Convert.ToInt32(Frm.Tag) == id && Frm.Text == "Dialog_Chat")
                    {
                        Check = true;
                        break;
                    }
                }
                if (!Check)
                {
                    Dialog_Chat Chat = new Dialog_Chat();
                    Chat.Tag = id;
                    Chat.Name_user = Name;
                    Chat.Show();
                    Listener.Forms.Add(Chat);
                    Chat.Show();
                }
            }
        }//Открытие чата

        private void Open_Task_Manager_Click(object sender, EventArgs e)
        {
            int id;
            string Name;
            foreach (ListViewItem item in List_User.SelectedItems)
            {
                id = Convert.ToInt32(List_User.Items[item.Index].SubItems[0].Text);
                Name = List_User.Items[item.Index].SubItems[1].Text;
                Dialog_Task_Manager Task_mng = new Dialog_Task_Manager();
                Task_mng.Tag = id;
                Task_mng.Text += " - " + Name;
                Task_mng.Show();
                Listener.Forms.Add(Task_mng);
            }
        } //Открытие диспетчера задач

        private void Open_Fun_Menu(object sender, EventArgs e)
        {
            int id;
            string Name;
            foreach (ListViewItem item in List_User.SelectedItems)
            {
                id = Convert.ToInt32(List_User.Items[item.Index].SubItems[0].Text);
                Name = List_User.Items[item.Index].SubItems[1].Text;
                Set_Speed_Cursor fun_menu = new Set_Speed_Cursor();
                fun_menu.Tag = id;
                fun_menu.Text += " - " + Name;
                fun_menu.Show();
            }
        } //Открытие Fun Menu

        private void Open_File_Manager_Click(object sender, EventArgs e)
        {
            int id;
            string Name;
            foreach (ListViewItem item in List_User.SelectedItems)
            {
                id = Convert.ToInt32(List_User.Items[item.Index].SubItems[0].Text);
                Name = List_User.Items[item.Index].SubItems[1].Text;
                Dialog_File_Manager File_Manager = new Dialog_File_Manager();
                File_Manager.Tag = id;
                File_Manager.Text += " - " + Name;
                Listener.Forms.Add(File_Manager);
                File_Manager.Show();
            }
        } // Открытие File Manager
        private void Remote_Desktop_Show_Click(object sender, EventArgs e)
        {
            int id;
            string Name;
            foreach (ListViewItem item in List_User.SelectedItems)
            {
                id = Convert.ToInt32(List_User.Items[item.Index].SubItems[0].Text);
                Name = List_User.Items[item.Index].SubItems[1].Text;
                Dialog_Remote_Desktop Remote_Form = new Dialog_Remote_Desktop();
                Remote_Form.Tag = id;
                Remote_Form.Text += " - " + Name;
                Listener.Forms.Add(Remote_Form);
                Remote_Form.Show();
            }
        }
        private void Open_Cmd_Form(object sender, EventArgs e)
        {
            int id;
            string Name;
            foreach (ListViewItem item in List_User.SelectedItems)
            {
                id = Convert.ToInt32(List_User.Items[item.Index].SubItems[0].Text);
                Name = List_User.Items[item.Index].SubItems[1].Text;
                Dialog_cmd cmd_form = new Dialog_cmd();
                cmd_form.Tag = id;
                cmd_form.Text += " - " + Name;
                Listener.Forms.Add(cmd_form);
                cmd_form.Show();
            }
        }

        #endregion
        /*========================*/

        #region add user
        delegate void _Add(int ID_User, string username, string status, string version);
        void Add(int ID_User, string username, string status, string version)
        {
            ListViewItem item = new ListViewItem(new string[] { ID_User.ToString(), username, status, version });
            List_User.Items.Add(item);
            Count_Online.Text = "Online: " + List_User.Items.Count;
        } //Add User

        #endregion 

        #region Change Status
        delegate void _ChangeStatus(int ID_User, string Status);
        void ChangeStatus(int ID_User, string Status)
        {
            foreach (ListViewItem item in List_User.Items)
            {
                int id = Convert.ToInt32(List_User.Items[item.Index].SubItems[0].Text);
                if (id == ID_User)
                {
                    List_User.Items[item.Index].SubItems[2].Text = Status;
                    break;
                }
            }
        } //Смена статуса

        #endregion

        #region Delete User
        delegate void _Delete_User(int ID_User);
        void Delete_User(int ID_User)
        {
            foreach (ListViewItem item in List_User.Items)
            {
                int id = Convert.ToInt32(List_User.Items[item.Index].SubItems[0].Text);
                if (id == ID_User)
                {
                    List_User.Items.RemoveAt(item.Index);
                    Count_Online.Text = "Online: " + List_User.Items.Count;
                    break;
                }
            }
        } //Удаление пользователя

        #endregion

        private void Build_Click(object sender, EventArgs e)
        {
            Builder_Form frm = new Builder_Form();
            frm.ShowDialog();
        }

        private void Set_port_click(object sender, EventArgs e)
        {
            if(Regex.Match(Port_text.Text, @"(^\d{1,5}$)").Groups.Count > 0 && Port_text.Text != "")
            {
                Data.Port = Convert.ToInt32(Port_text.Text);
                Show_Port.Text = $"Port is {Data.Port}";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pass frm = new Pass();
            if (frm.ShowDialog() == DialogResult.OK)
                return;
            else
                Application.Exit();
        }

        private void TopMost_Click(object sender, EventArgs e)
        {
            switch((sender as ToolStripItem).Text)
            {
                case "On":
                    this.TopMost = true;
                    break;
                case "Off":
                    this.TopMost = false;
                    break;
            }
        }

    }
}
