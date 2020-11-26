using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Xml;

namespace ProvaClasse
{

    public partial class SpaceshipTechnical : Control_Library.BaseForm
    {
        string tituloS;
        string pdfS;
        string blueprintS;
        string descS;
        string mp4S;
        string img_frontS;
        string img_sideS;
        string img_topS;
        string img_rearS;
        string img_rear_360S;
        string manufacturerS;
        string lengthS;
        string speedS;
        string hyperdriveS;
        string shieldingS;
        string armamentS;
        public SpaceshipTechnical()
        {
            InitializeComponent();
        }

        private void SpaceshipTechnical_Load(object sender, EventArgs e)
        {
            //FUENTES
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("../font/SF Distant Galaxy.ttf");
            lbl_fija.Font = new Font(pfc.Families[0], 18, FontStyle.Regular);
            lbl_fija2.Font = new Font(pfc.Families[0], 18, FontStyle.Regular);



            XmlDocument doc = new XmlDocument();
            doc.Load("../img/blueprintimages/Info.xml");


            XmlNode root = doc.DocumentElement;
            XmlNodeList spaceshipList = doc.GetElementsByTagName("textOption");

            //Consigo imagenes
            getImages();

            list_naves.View = View.SmallIcon;
            imageList1.ImageSize = new Size(32, 32);
            list_naves.SmallImageList = imageList1;
            int imageCount = 0;

            foreach (XmlNode node in spaceshipList)
            {
                list_naves.Items.Add(new ListViewItem { Text = node.InnerText, ImageIndex = imageCount });
                imageCount++;
            }

        }

        private void list_naves_Click(object sender, EventArgs e)
        {
            //makeVisible(false);


            int numeroElegir = list_naves.FocusedItem.Index;
            getInfo(numeroElegir);
            String spaceShipSelectName = list_naves.FocusedItem.Text;
            String rutaSpaceshipSelect = "../img/blueprintimages/" + spaceShipSelectName + "/";


            pbox_blueprint.Image = (Image.FromFile(rutaSpaceshipSelect + blueprintS));
            lbl_desc.Text = descS;


            makeVisible(true);


        }

        public void getImages()
        {
            String ruta = "../img/blueprintimages/iconShips/";
            String imagepath = "";

            XmlDocument doc = new XmlDocument();
            doc.Load("../img/blueprintimages/Info.xml");

            XmlNode root = doc.DocumentElement;
            XmlNodeList iconList = doc.GetElementsByTagName("icon");

            foreach (XmlNode node in iconList)
            {
                imagepath = node.InnerText;
                imageList1.Images.Add(Image.FromFile(ruta + imagepath));

            }
        }

       public void getInfo(int numberSpaceship)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../img/blueprintimages/Info.xml");

            XmlNodeList spaceshipSelected;
            spaceshipSelected = doc.SelectNodes("GeneralInfo/TechnicalInfo/InfoDetails/InfoDetail[idInfoDetail='" + numberSpaceship + "']");


            foreach (XmlNode node in spaceshipSelected)
            {
                //generales
                tituloS = node["title"].InnerText;
                pdfS = node["pdfFile"].InnerText;
                blueprintS = node["Blueprint"].InnerText;
                descS = node["textInfoDetail"].InnerText;
                mp4S = node["GeneralView"].InnerText;
                img_frontS = node["FrontView"].InnerText;
                img_sideS = node["SideView"].InnerText;
                img_topS = node["TopView"].InnerText;
                img_rearS = node["RearView"].InnerText;
                img_rear_360S = node["View360"].InnerText;

            }

            //info detallada
            XmlNodeList dataSpaceShip = doc.SelectNodes("GeneralInfo/TechnicalInfo/InfoDetails/InfoDetail[idInfoDetail='" + numberSpaceship + "']/Data");


            foreach (XmlNode item in dataSpaceShip)
            {
                manufacturerS = item["Manufacturer"].InnerText;
                lengthS = item["Length"].InnerText;
                speedS = item["Speed"].InnerText;
                hyperdriveS = item["Hyperdrive"].InnerText;
                shieldingS = item["Shielding"].InnerText;
                armamentS = item["Armament"].InnerText;

                //Console.WriteLine("Name: {0} {1}", manufacturerS, speedS);
            }

        }

        public void makeVisible(bool option)
        {
            pbox_principal.Visible = option;
            lbl_desc.Visible = option;
            lbl_fija.Visible = option;
            lbl_fija2.Visible = option;
            lbl_nave.Visible = option;
            pbox_blueprint.Visible = option;
            tbl_galeria.Visible = option;
            tbl_info.Visible = option;
        }

        public void FillLabels()
        {
            String letra = "";


            //VERTICAl
            for (int i = 1; i < 5; i++)
            {
                //Agregamos el Label
                Label lbl = new Label();
                //Detalles para crear el Label
                lbl.Font = new Font("Impact", 18);
                lbl.ForeColor = Color.FromArgb(248, 220, 51);

                switch (i)
                {
                    case 1:
                        lbl.Text = "A";
                        lbl.Name = "lbl_" + letra;
                        break;
                    case 2:
                        lbl.Text = "B";
                        break;
                    case 3:
                        lbl.Text = "C";
                        break;
                    case 4:
                        lbl.Text = "D";
                        break;
                    default:
                        break;
                }

                lbl.Name = "lbl_" + letra;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Dock = DockStyle.Fill;
                //tbl_Coord.Controls.Add(lbl, 0, i);



            }

        }

    }
}
