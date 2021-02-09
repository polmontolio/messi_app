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

namespace StarKiller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            UdpClient client = new UdpClient();
            client.Connect(txt_IPSistema.Text, int.Parse(txt_PortSistema.Text));
            byte[] sendBytes;
            sendBytes = Encoding.ASCII.GetBytes(txt_SendMsg.Text);
            client.Send(sendBytes, sendBytes.Length);
        }
    }
}
