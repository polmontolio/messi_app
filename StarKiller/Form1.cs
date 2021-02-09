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
using System.Net;

namespace StarKiller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool connected = false;
        UdpClient server;
        Thread t_connect;

        // SERVER CONFIG

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            connected = true;
            t_connect = new Thread(serverHilo);
            t_connect.Start();

            btn_Connect.Enabled = false;
            
        }

        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            if (server != null)
            {
                connected = false;
                btn_Disconnect.Enabled = false;
                btn_Connect.Enabled = true;
            }

            if (t_connect != null)
            {
                t_connect.Abort();
            }

        }

        private void serverHilo()
        {
            server = new UdpClient(int.Parse(txt_PortBase.Text));

            while (connected)
            {
                Control.CheckForIllegalCrossThreadCalls = false;
                IPEndPoint IeP = new IPEndPoint(IPAddress.Any, 0);
                Byte[] BytesIn = server.Receive(ref IeP);
                string returnData = Encoding.ASCII.GetString(BytesIn);
                Console.WriteLine(returnData);
                lbx_RecievedMsg.Items.Add(returnData);
            }
        }

        // CLIENT CONFIG


        private void btn_Send_Click(object sender, EventArgs e)
        {

            UdpClient client = new UdpClient();
            byte[] sendBytes;
            client.Connect(txt_IPSistema.Text, int.Parse(txt_PortSistema.Text));
            sendBytes = Encoding.ASCII.GetBytes(txt_SendMsg.Text);
            client.Send(sendBytes, sendBytes.Length);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

    }
}
