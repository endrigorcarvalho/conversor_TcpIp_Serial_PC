using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using ConversorTcpIpSerial.Services;
using ConversorTcpIpSerial.Entities;
using System.Net;
using System.Threading;


namespace ConversorTcpIpSerial
{
    public partial class Form1 : Form
    {

        private Conversor _conversor { get; set; } = new Conversor();

        private delegate void SafeCallDelegate(string text);

      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (var IpString in TcpIp.GetArrayIp())
            {
                cbIpServer.Items.Add(IpString);
            }
            cbIpServer.SelectedIndex = 0;
            //cbIpServer.SelectedIndex = cbIpServer.Items.Count-1;


            tbPortServer.Text = "599";


            // Config Serial
            foreach(var serialString in Serial.GetPorts())
            {
                cbSerialPort.Items.Add(serialString);
            }
            cbSerialPort.SelectedIndex = 0;

            cbBaudRate.Items.Add(9600);
            cbBaudRate.Items.Add(19200);
            cbBaudRate.Items.Add(38400);
            cbBaudRate.Items.Add(57600);
            cbBaudRate.Items.Add(115200);
            cbBaudRate.SelectedText = "9600" ;

            cbParity.Items.Add(Parity.Even);
            cbParity.Items.Add(Parity.Mark);
            cbParity.Items.Add(Parity.None);
            cbParity.Items.Add(Parity.Odd);
            cbParity.Items.Add(Parity.Space);
            cbParity.SelectedText = Parity.None.ToString();

            tbDataBits.Text = "8";

            cbStopBits.Items.Add(StopBits.None);
            cbStopBits.Items.Add(StopBits.One);
            cbStopBits.Items.Add(StopBits.OnePointFive);
            cbStopBits.Items.Add(StopBits.Two);
            cbStopBits.SelectedText = StopBits.One.ToString();

            

        }


        private void btOpenDoor_Click(object sender, EventArgs e)
        {
            var bd = int.Parse(cbBaudRate.Text);
            var teste = (Parity)Enum.Parse(typeof(Parity), cbParity.Text);
            var data = int.Parse(tbDataBits.Text);
            var stop = (StopBits)Enum.Parse(typeof(StopBits), cbStopBits.Text);

            bool resp = _conversor.StartSerial(cbSerialPort.Text, int.Parse(cbBaudRate.Text), (Parity)Enum.Parse(typeof(Parity), cbParity.Text), int.Parse(tbDataBits.Text), (StopBits)Enum.Parse(typeof(StopBits), cbStopBits.Text), receiverByte);
            if(resp)
            {
                Log("Conexão Serial Aberta");
            } else
            {
                Log("Erro ao abrir Conexão Serial");
            }
                
        }

        private void btCloseDoor_Click(object sender, EventArgs e)
        {
            bool resp = _conversor.StopSerial();
            if (resp)
            {                
                Log("Conexão Serial Fechada");
            }
            else
            {                
                Log("Erro ao fechar Conexão Serial");
            }
        }

        private void btStartConnect_Click(object sender, EventArgs e)
        {
            IPAddress iPAddress = IPAddress.Parse(cbIpServer.Text);
            if( _conversor.StartServer(iPAddress, int.Parse(tbPortServer.Text), receiverByte))
            {
                Log("Servidor Tcp/Ip inicializado com sucesso...");
            }else
            {
                Log("Erro ao inicializar servidor Tcp/Ip...");
            }
        }

        private void receiverByte(byte [] message)
        {
            string msg = "Mensagem Recebida: " + Encoding.ASCII.GetString(message, 0, message.Length);
            Log(msg);
        }

        private void Log(string msg)
        {


            if (lbLog.InvokeRequired)   // Fazer outra thread escrever em um componente do windows forms
            {
                var d = new SafeCallDelegate(Log);
                lbLog.Invoke(d, new object[] { msg });
            }
            else
            {
                lbLog.Items.Add(msg);
                statusStrip1.Items.Clear();
                statusStrip1.Items.Add(msg);
            }

        }

        private void btCloseConectionTcpIp_Click(object sender, EventArgs e)
        {
            if(_conversor.StopServer())
            {
                Log("Servidor Tcp/Ip finalizado com sucesso...");
            }
            else
            {
                Log("Erro ao finalizar servidor Tcp/Ip...");
            }
        }

        private void btEnviarMensagemTcpIp_Click(object sender, EventArgs e)
        {
            if(_conversor.SendMessageTcpIp(Encoding.ASCII.GetBytes(tbMensagemTcpIp.Text)))
            {
                Log("Mensagem enviada com sucesso do servidor Tcp/Ip...");
            } else
            {
                Log("Erro ao enviar mensagem do servidor Tcp/Ip...");
            }
        }

            

        private void button3_Click(object sender, EventArgs e)
        {
            lbLog.Items.Clear();
        }

        private void btSendMessageSerial_Click(object sender, EventArgs e)
        {
            if (_conversor.SendMessageSerial(Encoding.ASCII.GetBytes(tbMensagemSerial.Text)))
            {
                Log("Mensagem enviada com sucesso para a serial...");
            }
            else
            {
                Log("Erro ao enviar mensagem para a serial...");
            }
        }

  
    }
}
