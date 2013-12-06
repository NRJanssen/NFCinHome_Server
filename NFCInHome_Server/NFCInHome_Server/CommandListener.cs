﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;
using System.Net.Sockets;

namespace NFCInHome_Server
{
    class CommandListener
    {
        private TcpListener tcpListener;
        private Thread listenThread;
        public CommandListener()
        {
            tcpListener = new TcpListener(IPAddress.Any, 2000);
            listenThread = new Thread(new ThreadStart(ListenForClients));
            listenThread.Start();
        }

        private void ListenForClients()
        {
            tcpListener.Start();

            while (true)
            {
                //blocks until a client has connected to the server
                TcpClient client = tcpListener.AcceptTcpClient();

                //create a thread to handle communication 
                //with connected client
                Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientComm));
                clientThread.Start(client);
            }
        }

        private static void HandleClientComm(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();

            byte[] message = new byte[4096];
            int bytesRead;

            while (true)
            {
                bytesRead = 0;

                try
                {
                    //blocks until a client sends a message
                    bytesRead = clientStream.Read(message, 0, 4096);
                }
                catch
                {
                    //a socket error has occured
                    break;
                }

                if (bytesRead == 0)
                {
                    //the client has disconnected from the server
                    break;
                }

                //message has successfully been received
                ASCIIEncoding encoder = new ASCIIEncoding();
                System.Diagnostics.Debug.WriteLine(encoder.GetString(message, 0, bytesRead));
            }

            tcpClient.Close();
        }
    }
}