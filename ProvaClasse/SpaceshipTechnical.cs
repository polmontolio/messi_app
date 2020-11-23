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
                list_naves.Items.Add(new ListViewItem { Text = node.InnerText , ImageIndex = imageCount});
                imageCount++;
            }

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
    }
}
