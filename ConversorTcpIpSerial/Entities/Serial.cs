using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;

namespace ConversorTcpIpSerial.Entities
{
    class Serial
    {
        
        public SerialPort SerialPort { get; set; }
        private Action<byte[]> _actionReceiverData;
        private ManualResetEvent _flagThread = new ManualResetEvent(true);
        private Thread _trReceiver;

        public Serial()
        {
            
        }

        public Serial(SerialPort serialPort, Action<byte[]> actionReceiverData)
        {
            SerialPort = serialPort;
            _actionReceiverData = actionReceiverData;

            _flagThread.Set();

            _trReceiver = new Thread(ReadSerial);
            _trReceiver.IsBackground = true;
            _trReceiver.Start();
            



        }
        public static string[] GetPorts()
        {
            return SerialPort.GetPortNames(); 
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="portName">PortName = COM1</param>
        /// <param name="baudrate">BaudRate = 9600</param>
        /// <param name="parity">Parity = none</param>
        /// <param name="dataBits">DataBits = 8</param>
        /// <param name="stopBits">StopBits = One</param>
        public Serial(string portName = "COM1", int baudrate = 9600, Parity parity = Parity.None, int dataBits = 8, StopBits stopBits = StopBits.One, Action<byte[]> actionReceiverData=null)
        {
            SerialPort = new SerialPort();

            SerialPort.PortName = portName;
            SerialPort.BaudRate = baudrate;
            SerialPort.Parity = parity;
            SerialPort.DataBits = dataBits;
            SerialPort.StopBits = stopBits;

            _actionReceiverData = actionReceiverData;

            _flagThread.Set();
            _trReceiver = new Thread(ReadSerial);
            _trReceiver.IsBackground = true;
            _trReceiver.Start();


        }
        
        public Boolean ConfigureSerial(string portName = "COM1", int baudrate = 9600, Parity parity = Parity.None, int dataBits = 8, StopBits stopBits = StopBits.One, Action<byte[]> actionReceiverData = null)
        {
            

            try
            {
                _flagThread.Reset();

                if (SerialPort == null)
                {
                    SerialPort = new SerialPort();
                }

                SerialPort.Close();

                SerialPort.PortName = portName;
                SerialPort.BaudRate = baudrate;
                SerialPort.Parity = parity;
                SerialPort.DataBits = dataBits;
                SerialPort.StopBits = stopBits;

                _actionReceiverData = actionReceiverData;

                SerialPort.Open();

                _trReceiver = new Thread(ReadSerial);
                _trReceiver.IsBackground = true;
                _trReceiver.Start();
                _flagThread.Set();

                return SerialPort.IsOpen;

            }

            catch(Exception e)
            {
                return false;
                throw new Exception("Erro ao criar Porta Serial");                
            }
                
                
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

            Thread trReceive = new Thread(ReadSerial);
            trReceive.IsBackground = true;
            trReceive.Start();

        }

        public bool CloseSerial()
        {
            _flagThread.Reset();
            SerialPort.Close();
            return !SerialPort.IsOpen;
        }

        public bool WriteSerial(byte[] data, int offset = 0)
        {           
            if(IsOpenSerial())
            {
                SerialPort.Write(data, offset, data.Length);                
                return true;
                
            }

            return false;
        }

        public void ReadSerial()
        {
            byte[] bytesReceived = new byte[SerialPort.ReadBufferSize];

            if(_actionReceiverData == null)
            {
                throw new Exception("Action nula.");
            }

            while(true)
            {
                if ((_flagThread.WaitOne()) && (IsOpenSerial()) && (SerialPort.BytesToRead > 0))
                {

                    SerialPort.Read(bytesReceived, 0, SerialPort.BytesToRead);
                    _actionReceiverData(bytesReceived);

                    bytesReceived = new byte[SerialPort.ReadBufferSize];

                }
            }            
                
        }

    }
}
