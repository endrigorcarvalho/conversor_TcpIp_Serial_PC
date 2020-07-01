using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConversorTcpIpSerial.Entities;
using System.IO.Ports;
using System.Net;

namespace ConversorTcpIpSerial.Services
{
    class Conversor
    {
        public Serial Serial { get; set; }
        public TcpIp TcpIp { get; set; }

        public Conversor()
        {
            Serial = new Serial();
            TcpIp = new TcpIp();
        }


        public bool StartSerial(string portName = "COM1", int baudrate = 9600, Parity parity = Parity.None, int dataBits = 8, StopBits stopBits = StopBits.One)
        {
            return Serial.ConfigureSerial(portName, baudrate, parity, dataBits, stopBits);
        }


        public bool StopSerial()
        {
            return Serial.CloseSerial();
        }

        public bool StartServer(IPAddress ipServer, int portServer, Action<byte[]> actionReceiverByte)
        {
            //return TcpIp.StartServer(ipServer, portServer, receiverByte);
            return TcpIp.StartServer(ipServer, portServer, actionReceiverByte);
        }


        public bool StopServer()
        {
            return TcpIp.StopServer();
        }

        public void SendMessageTcpIp(byte[] message)
        {
            TcpIp.SendMessage(message);
        }

    }
}
