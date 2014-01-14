using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace NFCInHome_Server
{
    class Server
    {
        private static int TCP_SERVER_PORT = 2000;
        private static bool server_active;
        private TcpClient client;
        private Form1 form;

        public Server(Form1 form)
        {
            this.form = form;
            server_active = true;
            Thread thread = new Thread(new ThreadStart(initializeServer));
            thread.Start();
        }

        private void initializeServer()
        {
            try
            {
                IPAddress localAddr = IPAddress.Parse(getLocalIPAddress());
                TcpListener server = new TcpListener(localAddr, TCP_SERVER_PORT);
                server.Start();
                Byte[] bytes = new Byte[1024];
                String data = null;
                while (server_active)
                {
                    Console.Write("Waiting for a connection... ");
                    client = server.AcceptTcpClient();
                    Console.WriteLine("Connected!");
                    data = null;
                    NetworkStream stream = client.GetStream();
                    int i;
                    i = stream.Read(bytes, 0, bytes.Length);
                    data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                    Console.WriteLine(String.Format("Received: {0}", data));
                    handleMessage(data);
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes("1");
                    stream.Write(msg, 0, msg.Length);
                    Console.WriteLine(String.Format("Sent: {0}", data));
                    Console.WriteLine("Ready for new connection");
                }
                client.Close();
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }

            Console.WriteLine("\nHit enter to continue...");
            Console.Read();
        }

        public void stopListening()
        {
            server_active = false;
        }
        private string getLocalIPAddress()
        {
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                    break;
                }
            }
            return localIP;
        }

        private void handleMessage(string message)
        {
            if (message.Length != 0)
            {
                string[] commands = message.Split(';');
                foreach (string command in commands)
                {
                    if (!command.Contains("\n"))
                    {
                        form.updateForm(command);
                        Console.WriteLine(command);
                    }
                }
            }
        }
    }
}
