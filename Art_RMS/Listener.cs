using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using Art_RMS.Forms;
using System.IO;

namespace Art_RMS
{
    class Listener : Data
    {
        public delegate void ServerReceived(int ID_User, byte[] response);
        public event ServerReceived Recesived;
        public void BeginListen()
        {
            while (true)
            {
                Thread.Sleep(500);
                TcpListener serverSocket = new TcpListener(IPAddress.Any, Port);
                serverSocket.Start();
                All_Clients.Add(serverSocket.AcceptTcpClient());
                Thread Listen = new Thread(() =>
                {
                    Listening(All_Clients.Count);
                });
                Listen.IsBackground = true;
                Listen.Start();
                serverSocket.Stop();
            }
        }

        public void Listening(int i)
        {
            NetworkStream stream = All_Clients[(i - 1)].GetStream();
            byte[] buffer = new byte[1024];
            while (true)
            {
                try
                {
                    using (var memStream = new MemoryStream())
                    {
                        Thread.Sleep(1);
                        do
                        {
                            int length = stream.Read(buffer, 0, 1024);
                            memStream.Write(buffer, 0, length);
                            Thread.Sleep(1);
                        }while (stream.DataAvailable);
                        if (memStream.Length != 0 && (memStream.ToArray()[0] != 0 && memStream.Length != 1))
                            Receive((i - 1), memStream.ToArray());
                    }
                }
                catch{ BreakConnect(i - 1); break; }
            }
        }

        private void BreakConnect(int i)
        {
            All_Clients[i].Close();
            Recesived(i, Encoding.UTF8.GetBytes("DELETE|"));
        }

        public void Receive(int ID_User, byte[] data)
        {
            List<Array> answer = GetMessage(data, 0);
            switch (Encoding.UTF8.GetString((byte[])answer[0]))
            {
                case "RESPONSE_TASK_MANAGER":
                    Functions.Fun_Task_Manager(ID_User, answer);
                    break;
                case "SEND_MESSAGE_CHAT":
                    Functions.Get_Message_From_User(ID_User, Encoding.UTF8.GetString((byte[])answer[1]));
                    break;
                case "RESPONSE_FILE_MANAGER":
                    Functions.Func_File_Manager(ID_User, answer);
                    break;
                case "RESPONSE_FILE_FROM_CLIENT":
                    Functions.Write_File((byte[])GetMessage(data, 2)[2], Encoding.UTF8.GetString((byte[])answer[1]));
                    break;
                case "RESPONSE_DESKTOP_IMAGE":
                    Functions.Get_Desktop_Screen(ID_User, (byte[])GetMessage(data, 1)[1]);
                    break;
                case "RESPONSE_REMOTE_COMMAND":
                    Functions.Response_Command(ID_User, Encoding.UTF8.GetString((byte[])GetMessage(data, 1)[1]));
                    break;
                default:
                    Recesived(ID_User, data);
                    break;
            }
        }

        #region Send
        public void Send(int i, string Message, byte[] file)
        {
            try {
                NetworkStream Stream = All_Clients[i].GetStream();
                byte[] buffer = Encoding.UTF8.GetBytes(Message);
                buffer = buffer.Concat(file).ToArray();
                Stream.Write(buffer, 0, buffer.Length);
            }catch(Exception e) {
                MessageBox.Show(e.Message);
            }
        } //With file
        public void Send(int i, string Message)
        {
            try {
                NetworkStream Stream = All_Clients[i].GetStream();
                byte[] buffer = Encoding.UTF8.GetBytes(Message);
                Stream.Write(buffer, 0, buffer.Length);
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        } //WithOut File
        #endregion

        public static List<Array> GetMessage(byte[] data, int split)
        {
            List<Array> message = new List<Array>();
            int split_i = 0;
            var resp = new List<byte>();
            foreach (var ARRitem in data.Select((value, i) => new { i, value }))
            {
                bool check = split_i >= split && split != 0 ? true : false;
                if (ARRitem.value == (byte)124 && !check)
                {
                    message.Add(resp.Select(item => (byte)item).ToArray());
                    resp.Clear();
                    split_i = split != 0 ? split_i + 1 : 0;
                }
                else
                    resp.Add(ARRitem.value);
                if (data.Length - 1 == ARRitem.i)
                    message.Add(resp.Select(item => (byte)item).ToArray());
            }
            return message;
        }

    }
}
