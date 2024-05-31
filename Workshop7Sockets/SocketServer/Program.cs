﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SocketServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipaddr = IPAddress.Any;

            IPEndPoint ipep = new IPEndPoint(ipaddr, 25000);

            try { 
                listenerSocket.Bind(ipep);
                listenerSocket.Listen(5);
                Socket client = listenerSocket.Accept();
                Console.WriteLine("Client connected: " + client.ToString() + "-Ip End Point: " + client.RemoteEndPoint.ToString());
                byte[] buff = new byte[128];
                int numberOfReceivedBytes = 0;

                while (true)
                {
                    numberOfReceivedBytes = client.Receive(buff);
                    Console.WriteLine("Number of received bytes: "+numberOfReceivedBytes);
                    string receivedText = Encoding.ASCII.GetString(buff, 0, numberOfReceivedBytes);
                    Console.WriteLine("Data sent by client is: " + receivedText);
                    client.Send(buff);
                    if (receivedText == "x") {
                        break;
                    }

                    Array.Clear(buff, 0, buff.Length);
                    numberOfReceivedBytes = 0;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}