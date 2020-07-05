namespace ConversorTcpIpSerial
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btStartConnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbIpServer = new System.Windows.Forms.ComboBox();
            this.btEnviarMensagemTcpIp = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbMensagemTcpIp = new System.Windows.Forms.TextBox();
            this.btCloseConectionTcpIp = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPortServer = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbSerialPort = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btSendMessageSerial = new System.Windows.Forms.Button();
            this.tbMensagemSerial = new System.Windows.Forms.TextBox();
            this.btCloseDoor = new System.Windows.Forms.Button();
            this.cbStopBits = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDataBits = new System.Windows.Forms.TextBox();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btOpenDoor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ip Servidor";
            // 
            // btStartConnect
            // 
            this.btStartConnect.Location = new System.Drawing.Point(391, 41);
            this.btStartConnect.Name = "btStartConnect";
            this.btStartConnect.Size = new System.Drawing.Size(106, 45);
            this.btStartConnect.TabIndex = 4;
            this.btStartConnect.Text = "Iniciar Conexão";
            this.btStartConnect.UseVisualStyleBackColor = true;
            this.btStartConnect.Click += new System.EventHandler(this.btStartConnect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbIpServer);
            this.groupBox1.Controls.Add(this.btEnviarMensagemTcpIp);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbMensagemTcpIp);
            this.groupBox1.Controls.Add(this.btCloseConectionTcpIp);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbPortServer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btStartConnect);
            this.groupBox1.Location = new System.Drawing.Point(29, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 400);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TCP/IP";
            // 
            // cbIpServer
            // 
            this.cbIpServer.FormattingEnabled = true;
            this.cbIpServer.Location = new System.Drawing.Point(27, 62);
            this.cbIpServer.Name = "cbIpServer";
            this.cbIpServer.Size = new System.Drawing.Size(244, 24);
            this.cbIpServer.TabIndex = 11;
            // 
            // btEnviarMensagemTcpIp
            // 
            this.btEnviarMensagemTcpIp.Location = new System.Drawing.Point(391, 177);
            this.btEnviarMensagemTcpIp.Name = "btEnviarMensagemTcpIp";
            this.btEnviarMensagemTcpIp.Size = new System.Drawing.Size(106, 45);
            this.btEnviarMensagemTcpIp.TabIndex = 10;
            this.btEnviarMensagemTcpIp.Text = "Enviar Mensagem";
            this.btEnviarMensagemTcpIp.UseVisualStyleBackColor = true;
            this.btEnviarMensagemTcpIp.Click += new System.EventHandler(this.btEnviarMensagemTcpIp_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Mensagem";
            // 
            // tbMensagemTcpIp
            // 
            this.tbMensagemTcpIp.Location = new System.Drawing.Point(27, 197);
            this.tbMensagemTcpIp.Name = "tbMensagemTcpIp";
            this.tbMensagemTcpIp.Size = new System.Drawing.Size(244, 22);
            this.tbMensagemTcpIp.TabIndex = 8;
            // 
            // btCloseConectionTcpIp
            // 
            this.btCloseConectionTcpIp.Location = new System.Drawing.Point(391, 105);
            this.btCloseConectionTcpIp.Name = "btCloseConectionTcpIp";
            this.btCloseConectionTcpIp.Size = new System.Drawing.Size(106, 45);
            this.btCloseConectionTcpIp.TabIndex = 7;
            this.btCloseConectionTcpIp.Text = "Fechar Conexão";
            this.btCloseConectionTcpIp.UseVisualStyleBackColor = true;
            this.btCloseConectionTcpIp.Click += new System.EventHandler(this.btCloseConectionTcpIp_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Porta";
            // 
            // tbPortServer
            // 
            this.tbPortServer.Location = new System.Drawing.Point(27, 125);
            this.tbPortServer.Name = "tbPortServer";
            this.tbPortServer.Size = new System.Drawing.Size(244, 22);
            this.tbPortServer.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbSerialPort);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btSendMessageSerial);
            this.groupBox2.Controls.Add(this.tbMensagemSerial);
            this.groupBox2.Controls.Add(this.btCloseDoor);
            this.groupBox2.Controls.Add(this.cbStopBits);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbDataBits);
            this.groupBox2.Controls.Add(this.cbParity);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbBaudRate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btOpenDoor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(613, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(549, 400);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial";
            // 
            // cbSerialPort
            // 
            this.cbSerialPort.FormattingEnabled = true;
            this.cbSerialPort.Location = new System.Drawing.Point(27, 61);
            this.cbSerialPort.Name = "cbSerialPort";
            this.cbSerialPort.Size = new System.Drawing.Size(175, 24);
            this.cbSerialPort.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 336);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Mensagem";
            // 
            // btSendMessageSerial
            // 
            this.btSendMessageSerial.Location = new System.Drawing.Point(344, 336);
            this.btSendMessageSerial.Name = "btSendMessageSerial";
            this.btSendMessageSerial.Size = new System.Drawing.Size(106, 45);
            this.btSendMessageSerial.TabIndex = 12;
            this.btSendMessageSerial.Text = "Enviar Mensagem";
            this.btSendMessageSerial.UseVisualStyleBackColor = true;
            this.btSendMessageSerial.Click += new System.EventHandler(this.btSendMessageSerial_Click);
            // 
            // tbMensagemSerial
            // 
            this.tbMensagemSerial.Location = new System.Drawing.Point(27, 356);
            this.tbMensagemSerial.Name = "tbMensagemSerial";
            this.tbMensagemSerial.Size = new System.Drawing.Size(175, 22);
            this.tbMensagemSerial.TabIndex = 13;
            // 
            // btCloseDoor
            // 
            this.btCloseDoor.Location = new System.Drawing.Point(344, 189);
            this.btCloseDoor.Name = "btCloseDoor";
            this.btCloseDoor.Size = new System.Drawing.Size(106, 45);
            this.btCloseDoor.TabIndex = 12;
            this.btCloseDoor.Text = "Fechar Porta";
            this.btCloseDoor.UseVisualStyleBackColor = true;
            this.btCloseDoor.Click += new System.EventHandler(this.btCloseDoor_Click);
            // 
            // cbStopBits
            // 
            this.cbStopBits.FormattingEnabled = true;
            this.cbStopBits.Location = new System.Drawing.Point(27, 285);
            this.cbStopBits.Name = "cbStopBits";
            this.cbStopBits.Size = new System.Drawing.Size(175, 24);
            this.cbStopBits.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "StopBits";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Databits";
            // 
            // tbDataBits
            // 
            this.tbDataBits.Location = new System.Drawing.Point(27, 223);
            this.tbDataBits.Name = "tbDataBits";
            this.tbDataBits.Size = new System.Drawing.Size(175, 22);
            this.tbDataBits.TabIndex = 9;
            // 
            // cbParity
            // 
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Location = new System.Drawing.Point(27, 170);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(175, 24);
            this.cbParity.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Parity";
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Location = new System.Drawing.Point(27, 116);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(175, 24);
            this.cbBaudRate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Porta COM";
            // 
            // btOpenDoor
            // 
            this.btOpenDoor.Location = new System.Drawing.Point(344, 61);
            this.btOpenDoor.Name = "btOpenDoor";
            this.btOpenDoor.Size = new System.Drawing.Size(106, 45);
            this.btOpenDoor.TabIndex = 4;
            this.btOpenDoor.Text = "Abrir Porta";
            this.btOpenDoor.UseVisualStyleBackColor = true;
            this.btOpenDoor.Click += new System.EventHandler(this.btOpenDoor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "BaudRate";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 647);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbLog
            // 
            this.lbLog.FormattingEnabled = true;
            this.lbLog.ItemHeight = 16;
            this.lbLog.Location = new System.Drawing.Point(29, 454);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(1133, 148);
            this.lbLog.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(29, 608);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 25);
            this.button3.TabIndex = 15;
            this.button3.Text = "Limpar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 669);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Conversor TCP/IP - Serial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btStartConnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btOpenDoor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDataBits;
        private System.Windows.Forms.ComboBox cbStopBits;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btCloseDoor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPortServer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.Button btCloseConectionTcpIp;
        private System.Windows.Forms.Button btEnviarMensagemTcpIp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbMensagemTcpIp;
        private System.Windows.Forms.ComboBox cbIpServer;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btSendMessageSerial;
        private System.Windows.Forms.TextBox tbMensagemSerial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbSerialPort;
    }
}

