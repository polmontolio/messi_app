using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace CustomControl
{
    public partial class SpaceShipCard : UserControl
    {
        public string rutaImg = "../img/Balisses/";
        string CodeBeacon = "";
        string CodeSpaceship = "";
        bool blacklist = false;
        private string _targeta;
        public string Codigos
        {
            get { return _targeta; }
            set { _targeta = value; 
                string[] datos = _targeta.Split('|');
                CodeBeacon = datos[0];
                CodeSpaceship = datos[1];
            }
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
            //IMAGENES FIJAS
            pbox_road.Image = (Image.FromFile(rutaImg + "roadW.png"));
            pbox_desc.Image = (Image.FromFile(rutaImg + "ledW.png"));

            //////////DATOS DE LA RUTA
            DataSet ds_routeinfo = this.database.portarPerConsultar("select * from Routes r, ActiveBeacons a where a.codeBeacon = '" + this.CodeBeacon +"' and a.idRoute = r.idRoute");
            //llenamos campos
            lbl_RoadDesc.Text = ds_routeinfo.Tables[0].Rows[0]["descRoute"].ToString();
            lbl_BeaconDesc.Text = ds_routeinfo.Tables[0].Rows[0]["descBeacon"].ToString(); 

            /////////DATOS DE LA NAVE
            blacklist = BlacklistCheck(CodeSpaceship);
            DataSet ds_spacheship;
            DataSet ds_spaceship_blacklist;
            string tagid = CodeSpaceship.Substring(0, 1);
            ds_spacheship = this.database.portarPerConsultar("select * from ShipTypes st where st.TagId = '" + tagid);
            //LLENAMOS CUSTOM CONTROL
            if (!blacklist)
            {
                pbox_auth.BackColor = Color.Green;
                pbox_auth.Image = Image.FromFile(rutaImg + "check-mark.png");
                lbl_spaceship.Text = ds_spacheship.Tables[0].Rows[0]["DescTypeShip"].ToString();
                lbl_shipDescription.Text = "SpaceShip Information not available.";         
            }
            else
            {
                ds_spaceship_blacklist = this.database.portarPerConsultar("select * from BlackList where ShipTransporder = '" + CodeSpaceship + "'");
                pbox_auth.BackColor = Color.Red;
                pbox_auth.Image = Image.FromFile(rutaImg + "alert.png");
                lbl_spaceship.Text = ds_spaceship_blacklist.Tables[0].Rows[0]["DescShip"].ToString(); 
                lbl_shipDescription.Text = ds_spaceship_blacklist.Tables[0].Rows[0]["Remarks"].ToString();
            }

            switch (ds_spacheship.Tables[0].Rows[0]["idTypeShip"])
            {
                case 1:
                case 5:
                case 6:
                    pbox_spaceship.Image = (Image.FromFile(rutaImg + "PersonalShipW.png"));
                    break;
                case 3:
                case 4:
                    pbox_spaceship.Image = (Image.FromFile(rutaImg + "star-wars.png"));
                    break;
                case 2:
                    pbox_spaceship.Image = (Image.FromFile(rutaImg + "cargoW.png"));
                    break;
            }
        }

        private bool BlacklistCheck(string transporder)
        {
            DataSet ds = this.database.portarPerConsultar("select * from BlackList where ShipTransporder = "+ CodeSpaceship);

            return ds.Tables[0].Rows.Count > 0;
        }
    }
}
