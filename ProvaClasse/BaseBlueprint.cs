using System;
using System.Windows.Forms;
using System.Xml.Linq;
using Control_Library;
using System.Drawing;
using System.Linq;


namespace ProvaClasse
{
    public partial class BaseBlueprint : BaseForm
    {
        XElement documemt = null;
        String ruta;
        String rutaImageMain = "";
        String tituloDetail;
        String rutaImgDetail;
        String descDetail;
        public BaseBlueprint()
        {
            InitializeComponent();
        }

        private void BaseBlueprint_Load(object sender, EventArgs e)
        {
           
            ruta = "../img/blueprintimages/StarKiller/";

            // Cargar XML (Solo el nodo Blueprints)
            
            documemt = XElement.Load(@"../img/blueprintimages/Info.xml");
            // Crear listado del XML
            var listaBlueprint = documemt.Elements("Blueprints");


            // Bucle para buscar la imagenMain
            foreach (XElement ele in listaBlueprint)
            {
                rutaImageMain += ele.Element("imageMain").Value + "\r\n";
            }
                
            //Asignamos imagen
            pictureBox1.BackgroundImage = Image.FromFile(ruta + rutaImageMain);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnloGreen.Visible = true;
            pnloOrange.Visible = true;
            pnloYellow.Visible = true;
        }

        private void pnloOrange_Click(object sender, EventArgs e)
        {
            getDetail(1);
            pboxDetail.BackgroundImage = Image.FromFile(ruta + rutaImgDetail);
            txtDetail.Text = descDetail;
            lblDetail.Text = tituloDetail;
            txtDetail.Visible = true;


        }

        private void pnloGreen_Click(object sender, EventArgs e)
        {
            getDetail(2);
            pboxDetail.BackgroundImage = Image.FromFile(ruta + rutaImgDetail);
            txtDetail.Text = descDetail;
            lblDetail.Text = tituloDetail;
            txtDetail.Visible = true;
        }

        private void pnloYellow_Click(object sender, EventArgs e)
        {
            getDetail(3);
            pboxDetail.BackgroundImage = Image.FromFile(ruta + rutaImgDetail);
            txtDetail.Text = descDetail;
            lblDetail.Text = tituloDetail;
            txtDetail.Visible = true;
        }

        private void getDetail(int numeroDetail)
        {
            var listaDetails = documemt.Elements("Blueprints").Elements("Details");

            
            tituloDetail = (from ele in listaDetails.Elements("Detail")
                             where (int)ele.Element("idDetail") == numeroDetail
                            select ele.Element("title").Value).SingleOrDefault();

            rutaImgDetail = (from ele in listaDetails.Elements("Detail")
                            where (int)ele.Element("idDetail") == numeroDetail
                            select ele.Element("imageDetail").Value).SingleOrDefault();

            descDetail = (from ele in listaDetails.Elements("Detail")
                            where (int)ele.Element("idDetail") == numeroDetail
                            select ele.Element("textDetail").Value).SingleOrDefault();

        }



    }
}
