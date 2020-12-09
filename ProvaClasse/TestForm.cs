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
            ShowListView(puntosFormula);
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

        private void ShowListView(PointF[] puntosF)
        {

            listView1.Columns.Add("X");
            listView1.Columns.Add("Y");

            for (int j = 0; j < puntosF.Length; j += 25)
            {
                listView1.Items.Add(new ListViewItem(new string[] { puntosFormula[j].X.ToString(), puntosFormula[j].Y.ToString() }));
            }

            

            int k = listView1.Width - 5;
            int i = k / 2;
            listView1.Columns[0].Width = k - i - 17;
            listView1.Columns[1].Width = i;

        }


    }
}
