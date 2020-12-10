using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Xml;
using System.IO;
using System.Reflection;




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
        String rutaSpaceshipSelect;
        bool isOpen = false;
        String spaceShipSelectName;

        public SpaceshipTechnical()
        {
            InitializeComponent();
        }

        

        private void SpaceshipTechnical_Load(object sender, EventArgs e)
        {

            button1.Visible = false;
            makeVisible(false);

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
            getImagesListView();

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
            isOpen = false;
            webBrowser2.Visible = false;
            video_Spaceship.Visible = false;
            video_Spaceship.Ctlcontrols.stop();
            
            makeVisible(false);

            video_Spaceship.uiMode = "none";
            int numeroElegir = list_naves.FocusedItem.Index;
            spaceShipSelectName = list_naves.FocusedItem.Text;

            getInfo(numeroElegir);
          
            rutaSpaceshipSelect = "../img/blueprintimages/" + spaceShipSelectName + "/";


            pbox_blueprint.Image = (Image.FromFile(rutaSpaceshipSelect + blueprintS));
            pbox_principal.Image = (Image.FromFile(rutaSpaceshipSelect + img_frontS));
            lbl_desc.Text = descS;

            getImagesGallery(rutaSpaceshipSelect);

            filllabels();
            button1.Visible = true;

            makeVisible(true);

        }

        public void getImagesListView()
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

        public void getImagesGallery(String rutaselected)
        {
            tbl_galeria.Controls.Clear();

            String imagepath = "";
            
            for (int i = 0; i < 5; i++)
            {

                switch (i)
                {
                    case 0:
                        imagepath = img_frontS;
                        break;
                    case 1:
                        imagepath = img_sideS;
                        break;
                    case 2:
                        imagepath = img_topS;
                        break;
                    case 3:
                        imagepath = img_rearS;
                        break;
                    case 4:
                        imagepath = img_rear_360S;
                        break;
                    default:
                        break;
                }

                //Agregamos el pbox
                PictureBox pbox = new PictureBox();
                pbox.Image = Image.FromFile(rutaselected + imagepath);
                pbox.SizeMode = PictureBoxSizeMode.Zoom;
                pbox.Dock = DockStyle.Fill;
                if (i < 4)
                {
                    pbox.Click += new EventHandler(this.PictureBoxClick);
                } else
                {
                    pbox.Click += new EventHandler(this.ShowVideoClick);
                }
                
                //Console.WriteLine(rutaselected + imagepath);
                tbl_galeria.Controls.Add(pbox, i, 0);

            }

            
        }

        void PictureBoxClick(object sender, EventArgs e)
        {
            video_Spaceship.Visible = false;
            video_Spaceship.Ctlcontrols.stop();

            PictureBox pboxSender = (PictureBox)sender;
            Image saveImage = pboxSender.Image;

            pbox_principal.Image = saveImage;
            pbox_principal.SizeMode = PictureBoxSizeMode.Zoom;
            pbox_principal.Visible = true;

        }

        void ShowVideoClick(object sender, EventArgs e)
        {
            //Show the video settings
            pbox_principal.Visible = false;
            video_Spaceship.Visible = true;

            //Get path for videos
            string executableFilePath = Assembly.GetExecutingAssembly().Location;
            string executableDirectoryPath = Path.GetDirectoryName(executableFilePath);

            string videoPath = Path.GetFullPath(Path.Combine(executableDirectoryPath, @"" + rutaSpaceshipSelect + mp4S));



            //video_Spaceship.URL = @"E:/Messi_app/Messi_app/img/blueprintimages/Tie-Interceptor/TieInterceptor.mp4";
            video_Spaceship.URL = videoPath;


            //video_Spaceship.URL = @"C:/Users/pol/Desktop/MESSI/messi_app/img/blueprintimages/Tie - Advanced/TieAdvanced.mp4";
            video_Spaceship.settings.autoStart = true;

            video_Spaceship.settings.setMode("loop", true);

            //video_Spaceship.Ctlcontrols.play();
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
                descS = node["textInfoDetail"].InnerText.Trim();
                mp4S = node["GeneralView"].InnerText;
                img_frontS = node["FrontView"].InnerText;
                img_sideS = node["SideView"].InnerText;
                img_topS = node["TopView"].InnerText;
                img_rearS = node["RearView"].InnerText;
                img_rear_360S = node["View360"].InnerText;
                //Console.WriteLine("Name: {0} {1}", img_frontS, img_sideS);
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
            
            pbox_blueprint.Visible = option;
            tbl_galeria.Visible = option;
            tbl_info.Visible = option;
        }

        private void filllabels() {

            tbl_info.Controls.Clear();

            //COLUMNA 1
            for (int i = 0; i < 7; i++)
            {
                String texto_fijo = "";
                String texto_valor = "";

                switch (i)
                {
                    case 0:
                        texto_fijo = "DATA";
                        texto_valor = "VALUE";
                        break;
                    case 1:
                        texto_fijo = "Manufacturer";
                        texto_valor = manufacturerS;
                        break;
                    case 2:
                        texto_fijo = "Length";
                        texto_valor = lengthS;
                        break;
                    case 3:
                        texto_fijo = "Speed";
                        texto_valor = speedS;
                        break;
                    case 4:
                        texto_fijo = "Hyperdrive";
                        texto_valor = hyperdriveS;
                        break;
                    case 5:
                        texto_fijo = "Shielding";
                        texto_valor = shieldingS;
                        break;
                    case 6:
                        texto_fijo = "Armament";
                        texto_valor = armamentS;
                        break;
                    default:
                        break;
                }

                //Creamos las Label
                Label lbls_fijas = new Label();
                Label lbls_datos = new Label();

                //Detalles comunes para crear el Label
                lbls_fijas.Text = texto_fijo;
                lbls_fijas.Name = "lbl_fija" + i.ToString();
                lbls_fijas.TextAlign = ContentAlignment.MiddleCenter;
                lbls_fijas.Dock = DockStyle.Fill;
                

                lbls_datos.Text = texto_valor;
                lbls_datos.Name = "lbl_fija" + i.ToString();
                lbls_datos.TextAlign = ContentAlignment.MiddleCenter;
                lbls_datos.Dock = DockStyle.Fill;
                

                //Detalles no comunes
                if (i == 0)
                {
                    lbls_fijas.Font = new Font("Impact", 20);
                    lbls_fijas.ForeColor = Color.FromArgb(248, 220, 51);
                    lbls_datos.Font = new Font("Impact", 20);
                    lbls_datos.ForeColor = Color.FromArgb(248, 220, 51);
                }
                else
                {
                    lbls_fijas.Font = new Font("Impact", 18);
                    lbls_fijas.ForeColor = Color.Gainsboro;
                    lbls_datos.Font = new Font("Impact", 18);
                    lbls_datos.ForeColor = Color.Gainsboro;
                }

                //Agregamos Labels
                tbl_info.Controls.Add(lbls_fijas, 0, i);
                tbl_info.Controls.Add(lbls_datos, 1, i);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

           if (spaceShipSelectName.Length > 0)
            {
                //Get path for videos
                string executableFilePath = Assembly.GetExecutingAssembly().Location;
                string executableDirectoryPath = Path.GetDirectoryName(executableFilePath);

                string videoPath = Path.GetFullPath(Path.Combine(executableDirectoryPath, @"" + rutaSpaceshipSelect + pdfS));

                Console.WriteLine(videoPath);

                webBrowser2.ScriptErrorsSuppressed = true;
                webBrowser2.Url = new Uri("file:///" + videoPath);


                if (!isOpen)
                {
                    isOpen = true;
                    webBrowser2.Visible = true;

                }
                else
                {
                    isOpen = false;
                    webBrowser2.Visible = false;
                }
            }

            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
