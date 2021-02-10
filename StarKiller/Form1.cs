using System;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.IO;
using DataManagement;
using System.Drawing;

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
        StringData StringData = new StringData();
        int inicio = 1;
        int final = 300;
        double contador, resultado;
        double temperatura = 20;

        private PointF[] puntosFormula = new PointF[301];
        // SERVER CONFIG

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            connected = true;
            btn_Disconnect.Enabled = true;
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
            if (server == null)
            {
                server = new UdpClient(int.Parse(txt_PortBase.Text));
            }

            while (connected)
            {
                Control.CheckForIllegalCrossThreadCalls = false;
                IPEndPoint IeP = new IPEndPoint(IPAddress.Any, 0);
                Byte[] BytesIn = server.Receive(ref IeP);
                string returnData = Encoding.ASCII.GetString(BytesIn);
                RecievedMsg(returnData);
                lbx_RecievedMsg.Items.Add(returnData);
            }
        }

        // CLIENT CONFIG


        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (txt_IPSistema.Text.Length > 0 && txt_PortSistema.Text.Length > 0)
            {
                SendingMsg(txt_SendMsg.Text, txt_IPSistema.Text, txt_PortSistema.Text);
            }
        }

        private double Calculo(double x)
        {
                double y = Math.Pow(Math.E, (double)x / 100);
                //puntosFormula[x] = new PointF(x, (float)y);
                return y;
        }

        private void RecievedMsg(string message)
        {
            switch (message)
            {
                case "AYH":
                    //Console.WriteLine("ENTRA A AYH");
                    SendingMsg("IAR", txt_IPSistema.Text, txt_PortSistema.Text);
                    break;
                case "SLP":
                    //Arreglar con los tiempos
                    timer.Enabled = true;
                    timer.Interval = 500;
                    timer.Start();
                    break;
                case "FLP":
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }

        private void SendingMsg(string message, string ipBase, string portBase)
        {
            UdpClient client = new UdpClient();
            byte[] sendBytes;
            client.Connect(ipBase, int.Parse(portBase));
            sendBytes = Encoding.ASCII.GetBytes(message);
            client.Send(sendBytes, sendBytes.Length);
            /*
            client.Client.Close();
            client.Close();
            client.Dispose();
            */
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer_Tick(object sender, EventArgs e)
        { 
            resultado = Calculo(temperatura);
            SendingMsg("SKD|" + contador + "|" + resultado, txt_IPSistema.Text, txt_PortSistema.Text);
            temperatura++;
            contador += 0.5;
        }
    }
}
