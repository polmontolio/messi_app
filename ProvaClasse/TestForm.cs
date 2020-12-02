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


        private PointF[] p = new PointF[100];


        private void TestForm_Load(object sender, EventArgs e)
        {

            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);

            Calculo();
            //CalculoExponencial();

        }

        private void CalculoExponencial()
        {
            

            int space = 0;
            for (int x = 0; x < 100; x++)
            {

                double y = Math.Pow(x, 2);
                p[x] = new PointF(space, (float)y);
                space += 10;
            }
        }

        private void Calculo()
        {


            int space = 0;
            for (int x = 0; x < 20; x++)
            {

                double y = Math.Pow(Math.E, x) / 100;
                p[x] = new PointF(space, (float)y);
                space += 10;
            }
        }



        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.TranslateTransform(10, 400);
            e.Graphics.ScaleTransform(1, -0.25F);
            e.Graphics.DrawLines(Pens.Blue, p);
        }


    }
}
