using System;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.IO;
using System.Drawing;
using DataManagement;

namespace StarKillerBase
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        StringData StringData = new StringData();
        int inicio = 0;
        int final = 300;

        private PointF[] puntosFormula = new PointF[1001];

        private void Server_Load(object sender, EventArgs e)
        {

            ChartDesign();
            Calculo(inicio, final);
        }

        bool connected = false;
        UdpClient server;
        Thread t_connect;

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
                server = new UdpClient(int.Parse(txt_PortSistema.Text));
            }

            while (connected)
            {
                Control.CheckForIllegalCrossThreadCalls = false;
                IPEndPoint IeP = new IPEndPoint(IPAddress.Any, 0);
                Byte[] BytesIn = server.Receive(ref IeP);
                string returnData = Encoding.ASCII.GetString(BytesIn);

                RecievedMsg(returnData);

                //Console.WriteLine(returnData);
                lbx_RecievedMsg.Items.Add(returnData);
            }
        }

        // CLIENT CONFIG
        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (txt_IPBase.Text.Length > 0 && txt_PortBase.Text.Length > 0)
            {
                SendingMsg(txt_SendMsg.Text, txt_IPBase.Text, txt_PortBase.Text);
            }
        }

        private void ChartDesign()
        {
            crt_temp.BackColor = Color.Black;
            crt_temp.ChartAreas["ChartArea1"].BackColor = Color.Black;
            crt_temp.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.Gainsboro;
            crt_temp.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.Gainsboro;
            crt_temp.ChartAreas["ChartArea1"].AxisX.LabelStyle.ForeColor = Color.Gainsboro;
            crt_temp.ChartAreas["ChartArea1"].AxisY.LabelStyle.ForeColor = Color.Gainsboro;
            crt_temp.ChartAreas["ChartArea1"].AxisY.LineColor = Color.Gainsboro;
            crt_temp.ChartAreas["ChartArea1"].AxisX.LineColor = Color.Gainsboro;
            crt_temp.Series[0].Color = Color.FromArgb(248, 220, 51);
            crt_temp.Series[0].BorderWidth = 3;
            crt_temp.ChartAreas[0].AxisX.Minimum = 0;
            crt_temp.ChartAreas[0].AxisX.Maximum = 1100;
            crt_temp.ChartAreas[0].AxisY.Minimum = 0;
            crt_temp.ChartAreas[0].AxisY.Maximum = 25000;
        }

        private void Calculo(int inicio, int final)
        {
            for (int x = inicio; x <= final; x++)
            {
                double y = Math.Pow(Math.E, (double)x / 100);
                puntosFormula[x] = new PointF(x, (float)y);
                crt_temp.Series[0].Points.AddXY(x, (float)y);

                String StringX = StringData.FillIntChar(x, 4, " ");

                String log = StringX + " | " + y;

            }
        }

        private void RecievedMsg(string message)
        {
            switch (message)
            {
                case "AYH":
                    SendingMsg("IAR", txt_IPBase.Text, txt_PortBase.Text);
                    break;
                case "SLP":
                    for (int i = 0; i < puntosFormula.Length; i++)
                    {
                        SendingMsg("SKD|" + puntosFormula[i].X.ToString() +"|"+ puntosFormula[i].Y.ToString(), txt_IPBase.Text, txt_PortBase.Text);
                    }
                    
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
        }
    }
}
