using System;
using System.Windows.Forms;
using System.Drawing;
using DataManagement;
using System.IO;

namespace ProvaClasse
{
    public partial class GraphicForm : Control_Library.BaseForm
    {
        StringData StringData = new StringData();
        OpenFileDialog ofd = new OpenFileDialog();
        int inicio = 1;
        int final = 10;
        int aumento = 10;
        string path = "../DLL/";

        string fileName = "testing.log";

        private PointF[] puntosFormula = new PointF[1001];
        public GraphicForm()
        {
            InitializeComponent();
        }

        private void GraphicForm_Load(object sender, EventArgs e)
        {
            chart1.BackColor = Color.Black;
            chart1.ChartAreas["ChartArea1"].BackColor = Color.Black;
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.Gainsboro;
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.Gainsboro;
            chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.ForeColor = Color.Gainsboro;
            chart1.ChartAreas["ChartArea1"].AxisY.LabelStyle.ForeColor = Color.Gainsboro;
            chart1.ChartAreas["ChartArea1"].AxisY.LineColor = Color.Gainsboro;
            chart1.ChartAreas["ChartArea1"].AxisX.LineColor = Color.Gainsboro;
            chart1.Series[0].Color = Color.FromArgb(248, 220, 51);
            chart1.Series[0].BorderWidth = 3;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 1100;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 25000;


            timer1.Enabled = true;
            timer1.Interval = 25;
            timer1.Start();
            listView1.Visible = false;
            rtxt_datos.Visible = false;

            System.IO.File.WriteAllText(path + fileName, string.Empty);

            //Calculo(1, 1000);
            //ShowListView(puntosFormula);

            //string s = File.ReadAllText("../DLL/testing.log");
            //rtxt_datos.Text = s;

        }

        private void Calculo(int inicio, int final)
        {
            for (int x = inicio; x <= final; x++)
            {
                double y = Math.Pow(Math.E, (double)x / 100);
                puntosFormula[x] = new PointF(x, (float)y);
                chart1.Series[0].Points.AddXY(x, (float)y);

                String StringX = StringData.FillIntChar(x, 4, " ");

                String log = StringX + " | " + y;

                WriteLog(log);
            }
        }


        public static void WriteLog(string logline)
        {
            string path = "../DLL/";

            string fileName = "testing.log";

            

            try
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(path + fileName, true);
                file.WriteLine(logline);
                file.Close();
            }
            catch (Exception) { }

            
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

        private void timer1_Tick(object sender, EventArgs e)
        {

            
            if (final > 1001)
            {
                timer1.Enabled = false;
                timer1.Stop();
                ShowListView(puntosFormula);
                string s = File.ReadAllText("../DLL/testing.log");
                rtxt_datos.Text = s;
                listView1.Visible = true;
                rtxt_datos.Visible = true;
            } else
            {
                //Console.WriteLine("inicio: " + inicio + " final: " + final);
                Calculo(inicio, final);
                inicio += aumento;
                final += aumento;
            }
            
        }
    }
}
