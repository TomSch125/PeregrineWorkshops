using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ChatServer
{
    internal class Program
    {
        const int portNo = 25000;

        static void Main(string[] args)
        {
            IPAddress localAdd = IPAddress.Parse("127.0.0.1");
            TcpListener listener = new TcpListener(localAdd, portNo);
            listener.Start();
            while (true)
            {
                ChatClient user = new ChatClient(listener.AcceptTcpClient());

            }

        }
    }
}
