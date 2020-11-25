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
            
            //generales
            XmlNodeList list_titulos = doc.GetElementsByTagName("title");
            XmlNodeList list_pdf = doc.GetElementsByTagName("pdffile");
            XmlNodeList list_mp4 = doc.GetElementsByTagName("textInfoDetail");
            XmlNodeList list_desc = doc.GetElementsByTagName("title");
            XmlNodeList list_img_front = doc.GetElementsByTagName("FrontView");
            XmlNodeList list_img_side = doc.GetElementsByTagName("SideView");
            XmlNodeList list_img_top = doc.GetElementsByTagName("TopView");
            XmlNodeList list_img_rear = doc.GetElementsByTagName("RearView");

            //info detallada
            XmlNodeList list_manufacturer = doc.GetElementsByTagName("Manufacturer");
            XmlNodeList list_length = doc.GetElementsByTagName("Length");
            XmlNodeList list_speed = doc.GetElementsByTagName("Speed");
            XmlNodeList list_hyperdrive = doc.GetElementsByTagName("Hyperdrive");
            XmlNodeList list_shielding = doc.GetElementsByTagName("Shielding");
            XmlNodeList list_armament = doc.GetElementsByTagName("Armament");

            //este para hacer foreach
            XmlNodeList list_detail = doc.GetElementsByTagName("idInfoDetail");

            //foreach (XmlNodeList list in listasdelafuncionjoder)
            //{

            //}
            for (int i = 0; i < list_detail.Count; i++)
            {
                String[] information;

                information = getinfo(list_armament);

                //acciones
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
