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
            XmlDocument doc = new XmlDocument();
            doc.Load("../img/blueprintimages/Info.xml");


            int numeroElegir = list_naves.FocusedItem.Index;

            XmlNodeList spaceshipSelected;
            spaceshipSelected = doc.SelectNodes("GeneralInfo/TechnicalInfo/InfoDetails/InfoDetail[idInfoDetail='" + numeroElegir + "']");


            foreach (XmlNode node in spaceshipSelected)
            {
                //generales
                string tituloS = node["title"].InnerText;
                string pdfS = node["pdffile"].InnerText;
                string blueprintS = node["Blueprint"].InnerText;
                string descS = node["textInfoDetail"].InnerText;
                string mp4S = node["GeneralView"].InnerText;
                string img_frontS = node["FrontView"].InnerText;
                string img_sideS = node["SideView"].InnerText;
                string img_topS = node["TopView"].InnerText;
                string img_rearS = node["RearView"].InnerText;
                string img_rear_360S = node["View360"].InnerText;

                /*
                //info detallada
                string manufacturerS = node["Data/Manufacturer"].InnerText;
                string lengthS = node["Data/Length"].InnerText;
                string speedS = node["Data/Speed"].InnerText;
                string hyperdriveS = node["Data/Hyperdrive"].InnerText;
                string shieldingS = node["Data/Shielding"].InnerText;
                string armamentS = node["Data/Armament"].InnerText;

                */

                //Console.WriteLine("Name: {0} {1}", firstName, lastName);
            }


            pbox_principal.Visible = true;
            lbl_desc.Visible = true;
            lbl_fija.Visible = true;
            lbl_fija2.Visible = true;
            lbl_nave.Visible = true;
            lbl_nose.Visible = true;
            tbl_galeria.Visible = true;
            tbl_info.Visible = true;


            
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

        public String[] getinfo(XmlNodeList info) {

            foreach (XmlNode node in info)
            {
               

            }

            return null;
        }

    }
}
