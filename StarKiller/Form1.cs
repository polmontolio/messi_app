using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;

namespace StarKiller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        UdpClient client;
        bool connected = false;

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            Thread t_connect = new Thread(Connect);

            t_connect.Start();

            btn_Connect.Enabled = false;
        }
        
        private void Connect()
        {
            client = new UdpClient();
            client.Connect(txt_IPSistema.Text, int.Parse(txt_PortSistema.Text));
            connected = true;
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            
            byte[] sendBytes;
            sendBytes = Encoding.ASCII.GetBytes(txt_SendMsg.Text);
            client.Send(sendBytes, sendBytes.Length);
            
        }

        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                Thread t_disconnect = new Thread(Connect);

                t_disconnect.Start();
                btn_Disconnect.Enabled = false;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

    }
}
