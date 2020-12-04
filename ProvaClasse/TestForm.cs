using System;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Drawing;
using System.Xml;

namespace ProvaClasse
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }


        private PointF[] puntosFormula = new PointF[1001];


        private void TestForm_Load(object sender, EventArgs e)
        {
            Calculo();
        }


        private void Calculo()
        {
            for (int x = 0; x <= 1000; x++)
            {
                double y = Math.Pow(Math.E, (double)x / 100);
                puntosFormula[x] = new PointF(x, (float)y);
                chart1.Series[0].Points.AddXY(x, (float)y);
            }
        }
        
    }
}
