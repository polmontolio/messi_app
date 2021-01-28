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
using System.Threading;

namespace BalisesPassives
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string[] ports;
        static SerialPort _serialPort;

        private void Form1_Load(object sender, EventArgs e)
        {
            ports = SerialPort.GetPortNames();

            comboBox1.DataSource = ports.ToList();



            

        }

        private void PrintPorts()
        {
            Console.WriteLine("The following serial ports were found:");

            // Display each port name to the console.
            foreach (string port in ports)
            {
                Console.WriteLine(port);
            }

            Console.ReadLine();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _serialPort = new SerialPort();
            _serialPort.PortName = comboBox1.SelectedItem.ToString();
            _serialPort.BaudRate = 9600;
            _serialPort.Open();

            _serialPort.Write("1");
            _serialPort.Write("0");
            _serialPort.Close();



        }

        private void button2_Click(object sender, EventArgs e)
        {

            int gciclos;
            int divisor;

            gciclos = int.Parse(textBox1.Text);
            divisor = int.Parse(textBox2.Text);

            bool condicionCiclos = gciclos >= 5 && gciclos <= 20;
            bool condicionDivisor = divisor >= 2 && divisor <= 7;

            if (condicionCiclos && condicionDivisor)
            {
                _serialPort.Open();

                _serialPort.Write(gciclos.ToString());
                _serialPort.Write(divisor.ToString());
                _serialPort.Close();
            }


        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _serialPort.Close();
        }
    }
}
