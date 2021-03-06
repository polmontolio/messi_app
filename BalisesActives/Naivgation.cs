﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BalisesActives
{
    public partial class Naivgation : Form
    {
        public Naivgation()
        {
            InitializeComponent();
        }

        private double heightPic;
        private double widthPic;
        private double unitH;
        private double unitW;
        private DateTime date;
        string[] ports;
        static SerialPort _serialPort;
        Thread runningPort;
        public string rutaImg = "../img/Bali/";
        private Database.SqlDatabase database = new Database.SqlDatabase("DarkCore");
        private int counter = 0;
        bool running = false;
        private void Naivgation_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            date = DateTime.Now;
            GetTrafficTable();
            Control.CheckForIllegalCrossThreadCalls = false;

            heightPic = panel1.Size.Height;
            widthPic = panel1.Size.Width;
            unitH = heightPic / 21;
            unitW = widthPic / 23;
            ports = SerialPort.GetPortNames();
            connect();
        }

        private void connect()
        {
            runningPort = new Thread(openPort);


            runningPort.Start();
            running = true;
        }

        private void openPort()
        {
            _serialPort = new SerialPort();
            _serialPort.PortName = ports[0];
            _serialPort.BaudRate = 9600;
            _serialPort.Open();

            while (running)
            {
                try
                {
                    string line = _serialPort.ReadLine();
                    Console.WriteLine(line);
                    if (this.InvokeRequired)
                    {
                        this.BeginInvoke((MethodInvoker)delegate ()
                        {
                            CreateSpaceship(line);
                        });
                    }

                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
                

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateSpaceship("PEQU|C92FBF99");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateSpaceship("PEQU|63306D02");
        }


        private void GetTrafficTable()
        {

            string query = "select st.DescTypeShip, rt.ShipTransponder, rt.AuthorizedAccess, rt.TrafficDate, ab.descBeacon, ro.descRoute  " +
                "from RouteTraffic rt, ActiveBeacons ab, Routes ro, ShipTypes st where convert(date, rt.TrafficDate,101) = '" + date.ToString("MM-dd-yyyy") + "' " +
                "and rt.idBeacon = ab.idActiveBeacon and rt.idTypeShip = st.idTypeShip and ab.IdRoute = ro.idRoute; ";

            DataSet dataset = this.database.portarPerConsultar(query);
            dataGridView1.DataSource = dataset.Tables[0];
            dataGridView1.Columns[0].HeaderText = "TypeShip";
            dataGridView1.Columns[1].HeaderText = "Transponder";
            dataGridView1.Columns[1].HeaderText = "Access";
            dataGridView1.Columns[3].HeaderText = "Date";
            dataGridView1.Columns[4].HeaderText = "Beacon";
            dataGridView1.Columns[5].HeaderText = "Route";
        }

        private void InsertTrafficTable(CustomControl.SpaceShipCard card)
        {
            String idBeacon = card.idBeacon;
            String CodeSpaceship = card.CodeSpaceship;
            int idTypeShip = card.idTypeShip;
            int authorized = card.blacklist ? 0 : 1;
            date = DateTime.Now;


            string query = "INSERT INTO RouteTraffic(idBeacon, ShipTransponder, TrafficDate, idTypeShip, AuthorizedAccess) " +
                "VALUES(" + idBeacon + ",'" + CodeSpaceship + "', '" + date.ToString("yyyy-MM-dd HH:mm:ss:fff") + "', " + idTypeShip.ToString() + ", " + authorized.ToString() + ")";


            //Console.WriteLine(query);

            database.executa(query);
            GetTrafficTable();
        }

        private void CreateSpaceship(String codeCard)
        {

            if (counter >= 2)
            {
                Control Control = tableLayoutPanel1.GetControlFromPosition(0, 0);
                tableLayoutPanel1.Controls.Remove(Control);
            }

            counter++;
            CustomControl.SpaceShipCard spaceCard = new CustomControl.SpaceShipCard();
            spaceCard.Codigos = codeCard;
            spaceCard.Name = "spaceCard" + counter.ToString();

            tableLayoutPanel1.Controls.Add(spaceCard);

            String sector = spaceCard.sector;
            bool authorized = spaceCard.blacklist;
            CreateSign(sector, authorized);

            InsertTrafficTable(spaceCard);
        }

        private void CreateSign(String cadena, bool authorize)
        {
            if (counter >= 2)
            {
                foreach (Control item in panel1.Controls)
                {
                    if (item.Name == "pnl_" + (counter - 2).ToString())
                    {
                        panel1.Controls.Remove(item);
                        break;
                    }
                }

            }

            Panel pnl = new Panel();
            pnl.BackColor = authorize ? Color.Red : Color.Green;
            pnl.Name = "pnl_" + counter.ToString();
            pnl.Size = new Size(25, 25);
            int numH = getWordNumber(cadena.Substring(0, 1).ToUpper());
            int numW = int.Parse(cadena.Substring(1, cadena.Length - 1)) - 1;
            pnl.Location = new Point((int)(unitH * numH) + 2, (int)(unitW * numW) - 1);
            panel1.Controls.Add(pnl);
        }

        private int getWordNumber(String cadena)
        {
            char mychar = cadena[0];
            int numero = (int)mychar - 65;
            return numero;
        }

        private void Naivgation_FormClosing(object sender, FormClosingEventArgs e)
        {
            
                if (runningPort != null)
                {
                    running = false;
                    runningPort = null;
                }

                if (_serialPort.IsOpen || _serialPort != null)
                {
                    _serialPort.Close();
                    _serialPort.Dispose();

                }
            
            
        }

    }
    
}
