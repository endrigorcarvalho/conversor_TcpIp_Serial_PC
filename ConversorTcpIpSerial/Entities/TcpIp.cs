using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace ConversorTcpIpSerial.Entities
{
    class TcpIp
    {
               

        private TcpListener Server;
        private TcpClient Client = default(TcpClient);

        private Action<byte[]> _actionReceiverByte;

        private ManualResetEvent _flagThread = new ManualResetEvent(true);

        public static IPAddress GetIp()
        {
            

            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip;
                }
            }

            return null;
        }

        public bool StartServer(IPAddress ipServer, int portServer, Action<byte[]> actionReceiverByte = null)
        {
            try
            {
                _actionReceiverByte = actionReceiverByte;
                Server = new TcpListener(ipServer, portServer);
                Server.Start();

                _flagThread.Set();

                Thread trReceive = new Thread(ReceiveMessage);
                trReceive.IsBackground = true;
                trReceive.Start();

                return true;
            }
            catch(Exception e)
            {
                return false;
            }           

        }

        public bool StopServer()
        {
            try
            {
                _flagThread.Reset();
                if (Client != null) Client.Close();
                if (Server != null) Server.Stop();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public void ReceiveMessage()
        {
            while(true)
            {
                
                if ((_flagThread.WaitOne()) && (Server.Pending()))
                {
                    Client = Server.AcceptTcpClient();
                    byte[] receiverBuffer = new byte[100];
                    NetworkStream stream = Client.GetStream();
                    if(stream.DataAvailable)
                    {
                        stream.Read(receiverBuffer, 0, receiverBuffer.Length);
                        _actionReceiverByte(receiverBuffer);
                    }
                }else
                {
                    Thread.Sleep(100);
                }                
            }
        }

        public bool SendMessage(byte[] message)
        {
            if(Client.Connected)
            {
                StreamWriter stream = new StreamWriter(Client.GetStream());
                stream.Write(message);

                return true;

            } else
            {
                return false;
            }
        }
        


    }
}
