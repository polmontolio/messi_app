using System;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Drawing;

namespace ProvaClasse
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }



        private void TestForm_Load(object sender, EventArgs e)
        {

            
            //Alumnos
            XElement documemt = null;
            documemt = XElement.Load(@"../img/blueprintimages/Info.xml");


            var llistaAlumnes = documemt.Elements("TechnicalInfo").Elements("InfoDetails").Elements("InfoDetail");
            foreach (XElement ele in llistaAlumnes)
                txtResultat.Text += ele + "\r\n";


            // SEGUNDA PARTE
            var llistaModulos = documemt.Elements("TechnicalInfo").Elements("InfoOptions").Elements("InfoOption");
            

            getImages();

            listView1.View = View.LargeIcon;
            imageList1.ImageSize = new Size(32, 32);
            listView1.LargeImageList = imageList1;

            int imageCount = 0;

            foreach (XElement ele in llistaModulos)
            {
                listView1.Items.Add(new ListViewItem { ImageIndex = imageCount, Text = ele.Element("textOption").Value });
                txtModuls.Text += ele.Element("textOption").Value + "\r\n";
                imageCount++;
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void getImages()
        {
            String ruta = "../img/blueprintimages/iconShips/";
            String imagepath = "";

            XElement imagenes = null;
            imagenes = XElement.Load(@"../img/blueprintimages/Info.xml");


            var llistaImagenes = imagenes.Elements("TechnicalInfo").Elements("InfoOptions").Elements("InfoOption");
            foreach (XElement ele in llistaImagenes)
            {
                imagepath = ele.Element("icon").Value;
                imageList1.Images.Add(Image.FromFile(ruta + imagepath));
            }

        }
    }
}
