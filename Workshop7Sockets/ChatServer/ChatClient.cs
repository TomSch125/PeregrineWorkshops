using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Collections;
using System.Threading.Tasks.Dataflow;


namespace ChatServer
{
    internal class ChatClient
    {
        // all the clients
        public static Hashtable AllClients = new Hashtable();

        private TcpClient _client;
        private string _clientIP;
        private string _clientPort;
        private string _clientNick;

        private byte[] data;

        private bool ReceiveNick = true;

        public ChatClient(TcpClient client)
        {
            _client = client;
            //---get the client IP address---
            _clientIP = client.Client.RemoteEndPoint.ToString();

            //---add the current client to the hash table---
            AllClients.Add(_clientIP, this);

            data = new byte[_client.ReceiveBufferSize];
            client.GetStream().BeginRead(data, 0,System.Convert.ToInt32(_client.ReceiveBufferSize),ReceiveMessage, null); // starts a new thread

        }

        public void ReceiveMessage(IAsyncResult ar) {
            int bytesRead;
            try {
                lock (_client.GetStream()) { 
                    bytesRead = _client.GetStream().EndRead(ar);
                }
                if (bytesRead < 1) // means the client has disconnected
                {
                    AllClients.Remove(_clientIP);
                    Broadcast(_clientNick + " has left the chat.");
                    return;
                }
                else {
                    // get a message
                    string messageReceived = Encoding.ASCII.GetString(data, 0, bytesRead);
                    //---client is sending its nickname---
                    if (ReceiveNick)
                    {
                        _clientNick = messageReceived;
                        Broadcast(_clientNick + " has joined the chat. ");
                        ReceiveNick = false;
                    }
                    else {
                        Broadcast(_clientNick + ">" + messageReceived );
                    }
                }
                // Keep reading from the client
                lock (_client.GetStream())
                {
                    _client.GetStream().BeginRead(data, 0, System.Convert.ToInt32(_client.ReceiveBufferSize), ReceiveMessage, null);
                }

            }
            catch (Exception e)
            {
                AllClients.Remove(_clientIP);
                Broadcast(_clientNick + " has left the chat. ");
            }
        }

        public void SendMessage(string message)
        {
            try
            {
                System.Net.Sockets.NetworkStream ns;
                lock (_client.GetStream())
                {
                    ns = _client.GetStream();
                }

                byte[] bytesToSend = Encoding.ASCII.GetBytes(message);
                ns.Write(bytesToSend, 0, bytesToSend.Length);
                ns.Flush();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }

        }
        public void Broadcast(string message)
        {
            Console.WriteLine(message);
            foreach (DictionaryEntry c in AllClients)
            {
                ((ChatClient)(c.Value)).SendMessage(message + Environment.NewLine); // essentally /r/n but can change depending on enviromanet
            }
        }
    }
}
