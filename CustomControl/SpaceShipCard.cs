using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl
{
    
    public partial class SpaceShipCard : UserControl
    {
        public string rutaImg = "../img/Balisses/";

        public SpaceShipCard()
        {
            InitializeComponent();
        }

        private void SpaceShipCard_Load(object sender, EventArgs e)
        {       
           FillCustomControl();
        }
        private void FillCustomControl()
        {
            int idnau = 5;

            pbox_road.Image = (Image.FromFile(rutaImg + "roadW.png"));
            pbox_desc.Image = (Image.FromFile(rutaImg + "ledW.png"));

            switch (idnau)
            {
                case 1:
                case 5:
                case 6:
                    Console.WriteLine(6);
                    //pbox_spaceship.Image = (Image.FromFile(rutaImg + ""));
                    break;
                case 3:
                case 4:
                    Console.WriteLine(4);
                    //pbox_spaceship.Image = (Image.FromFile(rutaImg + ""));
                    break;
                case 2:
                    Console.WriteLine(2);
                    //pbox_spaceship.Image = (Image.FromFile(rutaImg + ""));
                    break;
            }

        }
    }
}
