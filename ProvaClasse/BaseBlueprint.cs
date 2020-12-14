using System;
using System.Windows.Forms;
using System.Xml.Linq;
using Control_Library;
using System.Drawing;
using System.Linq;
using System.Drawing.Text;


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
            // POSICIONES DE OBJETOS

            pboxDetail.Location = new Point(this.ClientSize.Width - pboxDetail.Size.Width - 170, 146 );


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



            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("../font/SF Distant Galaxy.ttf");
            lblDetail.Font = new Font(pfc.Families[0], 23, FontStyle.Regular);

            

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
            lblDetail.Location = new Point(this.ClientSize.Width - pboxDetail.Size.Width - 195, pboxDetail.Height - 80);
            asignDetail();
        }

        private void pnloGreen_Click(object sender, EventArgs e)
        {
            getDetail(2);
            lblDetail.Location = new Point(this.ClientSize.Width - pboxDetail.Size.Width - 190, pboxDetail.Height - 100);
            asignDetail();
        }

        private void pnloYellow_Click(object sender, EventArgs e)
        {
            getDetail(3);
            lblDetail.Location = new Point(this.ClientSize.Width - pboxDetail.Size.Width - 200, pboxDetail.Height - 100);
            asignDetail();
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

            lblDetail.Visible = false;
        }

        private void asignDetail()
        {

            lblDetail.Visible = true;
            pboxDetail.BackgroundImage = Image.FromFile(ruta + rutaImgDetail);
            txtDetail.Text = descDetail;
            lblDetail.Text = tituloDetail;
            txtDetail.Visible = true;

        }


    }
}
