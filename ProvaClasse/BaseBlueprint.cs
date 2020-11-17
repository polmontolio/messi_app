using System;
using System.Windows.Forms;
using System.Xml.Linq;
using Control_Library;
using System.Drawing;

namespace ProvaClasse
{
    public partial class BaseBlueprint : BaseForm
    {
        public BaseBlueprint()
        {
            InitializeComponent();
        }

        private void BaseBlueprint_Load(object sender, EventArgs e)
        {
            String rutaImageMain = "";
            String ruta = "../img/blueprintimages/StarKiller/";

            // Cargar XML (Solo el nodo Blueprints)
            XElement documemt = null;
            documemt = XElement.Load(@"../img/blueprintimages/Info.xml");
            // Crear listado del XML
            var listaBlueprint = documemt.Elements("Blueprints");


            // Bucle para buscar la imagenMain
            foreach (XElement ele in listaBlueprint)
                rutaImageMain += ele.Element("imageMain").Value + "\r\n";

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

        }

        private void pnloGreen_Click(object sender, EventArgs e)
        {

        }

        private void pnloYellow_Click(object sender, EventArgs e)
        {

        }
    }
}
