using System;
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
        private Form1 f;
        private Boolean keepListening = true;
        public CommandListener(Form1 f)
        {
            this.f = f;
            tcpListener = new TcpListener(IPAddress.Any, 2000);
            listenThread = new Thread(new ThreadStart(ListenForClients));
        }


        public void startListening()
        {
            listenThread.Start();
        }

        private void ListenForClients()
        {
            tcpListener.Start();

           while (keepListening)
            {
                TcpClient client = tcpListener.AcceptTcpClient();
                Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientComm));
                clientThread.Start(client);
            }
        }

        private void HandleClientComm(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();

            byte[] message = new byte[4096];
            int bytesRead;

           while (keepListening)
            {
                bytesRead = 0;

                try
                {
                    bytesRead = clientStream.Read(message, 0, 4096);
                }
                catch
                {
                   break;
                }

                if (bytesRead == 0)
                {
                   break;
                }
                ASCIIEncoding encoder = new ASCIIEncoding();
                string temp = encoder.GetString(message, 0, bytesRead);
                f.setLabel(temp);
            }

            tcpClient.Close();
        }

        public void setKeepListeningFalse()
        {
            keepListening = false;
        }
    }
}
