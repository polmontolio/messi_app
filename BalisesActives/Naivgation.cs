using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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

        public string rutaImg = "../img/Bali/";
        private void Naivgation_Load(object sender, EventArgs e)
        {
            
            heightPic = panel1.Size.Height;
            widthPic = panel1.Size.Width;
            unitH = heightPic / 21;
            unitW = widthPic / 23;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Panel pnl = new Panel();
            pnl.BackColor = Color.Red;
            pnl.Name = "pnl_1";
            pnl.Size = new Size(30, 30);
            string cadena = textBox1.Text;
            int numH = getWordNumber(cadena.Substring(0,1).ToUpper());
            int numW = int.Parse(cadena.Substring(1, cadena.Length - 1)) - 1;
            pnl.Location = new Point((int)(unitH * numH) + 1, (int)(unitW * numW) - 3);
            panel1.Controls.Add(pnl);
        }

        private int getWordNumber(String cadena)
        {
            char mychar = cadena[0];
            int numero = (int)mychar - 65;
            return numero;
        }
    }

}
