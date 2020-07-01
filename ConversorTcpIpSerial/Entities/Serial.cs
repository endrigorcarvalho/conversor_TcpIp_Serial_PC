using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace ConversorTcpIpSerial.Entities
{
    class Serial
    {
        
        public SerialPort SerialPort { get; set; }

        public Serial()
        {
        }

        public Serial(SerialPort serialPort)
        {
            SerialPort = serialPort;            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="portName">PortName = COM1</param>
        /// <param name="baudrate">BaudRate = 9600</param>
        /// <param name="parity">Parity = none</param>
        /// <param name="dataBits">DataBits = 8</param>
        /// <param name="stopBits">StopBits = One</param>
        public Serial(string portName = "COM1", int baudrate = 9600, Parity parity = Parity.None, int dataBits = 8, StopBits stopBits = StopBits.One )
        {
            SerialPort = new SerialPort();

            SerialPort.PortName = portName;
            SerialPort.BaudRate = baudrate;
            SerialPort.Parity = parity;
            SerialPort.DataBits = dataBits;
            SerialPort.StopBits = stopBits;

        }
        
        public Boolean ConfigureSerial(string portName = "COM1", int baudrate = 9600, Parity parity = Parity.None, int dataBits = 8, StopBits stopBits = StopBits.One)
        {
            if(SerialPort == null)
            {
                SerialPort = new SerialPort();
            }

            SerialPort.Close();

            SerialPort.PortName = portName;
            SerialPort.BaudRate = baudrate;
            SerialPort.Parity = parity;
            SerialPort.DataBits = dataBits;
            SerialPort.StopBits = stopBits;

            SerialPort.Open();

            return SerialPort.IsOpen;
        }
        public Boolean IsOpenSerial()
        {
            if(SerialPort == null)
            {
                return false;
            }

            return SerialPort.IsOpen;
        }

        public void OpenSerial()
        {
            SerialPort.Open();
        }

        public bool CloseSerial()
        {
            SerialPort.Close();
            return !SerialPort.IsOpen;
        }

        public void WriteSerial(byte[] data, int offset = 0)
        {            
            SerialPort.Write(data, offset, data.Length);          
        }

        public int ReadSerial()
        {   
            return SerialPort.ReadByte();
        }

    }
}
