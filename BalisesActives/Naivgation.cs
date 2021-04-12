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

        public string rutaImg = "../img/Bali/";
        private void Naivgation_Load(object sender, EventArgs e)
        {

            // pictureBox1.Image = (Image.FromFile(rutaImg + "ledW.png"));
            Console.WriteLine("width: " + pictureBox2.Size.Width.ToString() + " height: " + pictureBox2.Size.Height.ToString());
        }


    }

}
