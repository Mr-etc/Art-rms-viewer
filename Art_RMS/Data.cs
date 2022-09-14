using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace Art_RMS
{
    class Data
    {
        private static int port = 1723;
        public static int Port
        {
            get { return port; }
            set
            {
                port = value;
            }
        }

        public static List<TcpClient> All_Clients = new List<TcpClient>();
        public static List<Object> Forms = new List<Object>();
    }
}
