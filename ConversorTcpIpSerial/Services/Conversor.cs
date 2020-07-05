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

        private Action<byte[]> _actionReceiverDataSerial;

        private Action<byte[]> _actionReceiverDataTcpIp;


        public Conversor()
        {
            Serial = new Serial();
            TcpIp = new TcpIp();
        }

#region Config Serial


        public bool StartSerial(string portName = "COM1", int baudrate = 9600, Parity parity = Parity.None, int dataBits = 8, StopBits stopBits = StopBits.One, Action<byte[]> actionReceiverData = null)
        {
            _actionReceiverDataSerial = actionReceiverData;
            return Serial.ConfigureSerial(portName, baudrate, parity, dataBits, stopBits, ReceiveMessageSerial);
        }


        public bool StopSerial()
        {
            return Serial.CloseSerial();
        }


#endregion

#region Config Socket TCP/IP

        public bool StartServer(IPAddress ipServer, int portServer, Action<byte[]> actionReceiverData)
        {
            //return TcpIp.StartServer(ipServer, portServer, receiverByte);

            _actionReceiverDataTcpIp = actionReceiverData;
            return TcpIp.StartServer(ipServer, portServer, ReceiveMessageTcpIp);
        }


        public bool StopServer()
        {
            return TcpIp.StopServer();
        }

#endregion
        public bool SendMessageTcpIp(byte[] message)
        {
            return TcpIp.SendMessage(message);
        }

        public bool SendMessageSerial(byte[] message)
        {
            return Serial.WriteSerial(message);
        }

        public void ReceiveMessageSerial(byte[] message)
        {
            _actionReceiverDataSerial(message);
            TcpIp.SendMessage(message);
        }

        public void ReceiveMessageTcpIp(byte[] message)
        {
            _actionReceiverDataTcpIp(message);
            Serial.WriteSerial(message);
        }


    }
}
