using System;
using System.Windows.Forms;
using System.Xml.Linq;

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
            XElement alumnes = null;
            alumnes = XElement.Load(@"../alumnes.xml");


            var llistaAlumnes = alumnes.Elements("alumne");
            foreach (XElement ele in llistaAlumnes)
                txtResultat.Text += ele.Element("nom") + "\r\n";


            //Modulos
            XElement modulos = null;
            modulos = XElement.Load(@"../alumnes.xml");


            var llistaModulos = alumnes.Elements("alumne").Elements("moduls").Elements("modul");
            foreach (XElement ele in llistaModulos)
                txtModuls.Text += ele.Element("nomModul").Value + "\r\n";

        }
    }
}
