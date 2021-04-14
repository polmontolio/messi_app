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

            heightPic = pictureBox1.Size.Height;
            widthPic = pictureBox1.Size.Width;
            unitH = heightPic / 21;
            unitW = widthPic / 23;
            
            Console.WriteLine("width: " + unitW.ToString() + " height: " + unitH.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PictureBox pbox = new PictureBox();
            pbox.BackColor = Color.Red;
            pbox.Name = "pbox_1";
            pbox.Size = new Size(30, 30);
            pbox.Location = new Point((int)(unitH * 10), (int)(unitW * 15));
            this.Controls.Add(pbox);

        }
    }

}
