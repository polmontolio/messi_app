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
        string CodeBeacon = "";

        private string _targeta;
        public string MyProperty
        {
            get { return _targeta; }
            set { _targeta = value; }
        }


        private Database.SqlDatabase database = new Database.SqlDatabase("DarkCore");
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
            //IMAGENES FIJAS
            pbox_road.Image = (Image.FromFile(rutaImg + "roadW.png"));
            pbox_desc.Image = (Image.FromFile(rutaImg + "ledW.png"));

            //DATOS DE LA RUTA
            DataSet ds_routeinfo = this.database.portarPerConsultar("select * from Routes r, ActiveBeacons a where a.codeBeacon = '" + this.CodeBeacon +"' and a.idRoute = r.idRoute;");
           

            //DATOS DE LA NAVE
            DataSet ds_spacheship = this.database.portarPerConsultar("select * from Routes r, ActiveBeacons a where a.codeBeacon = '" + this.CodeBeacon + "' and a.idRoute = r.idRoute;");

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
