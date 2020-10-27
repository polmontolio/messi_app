using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control_Library;

namespace ProvaClasse
{
    public partial class AdminCoordScreen : BaseForm
    {
        public AdminCoordScreen()
        {
            InitializeComponent();
            //FillLabels();
            

        }

        private void AdminCoordScreen_Load(object sender, EventArgs e)
        {

        }

        private void tbl_Coord_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FillLabels()
        {
            String letra="";   
            
            //HORIZONTAL
            for (int i = 1; i < 6; i++)
            {
                //Agregamos el Label
                Label lbl = new Label();
                //Detalles para crear el Label
                lbl.Font = new Font("Impact", 18);
                lbl.ForeColor = Color.FromArgb(248, 220, 51);
                lbl.Text = i.ToString();
                lbl.Name = "lbl_Coord" + i.ToString();
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Dock = DockStyle.Fill;
                tbl_Coord.Controls.Add(lbl, i, 0);
            }
            
            //VERTICAl
            for (int i = 1; i < 5; i++)
            {

                switch (i)
                {
                    case 1:
                        letra= "A";
                        break;
                    case 2:
                        letra = "B";
                        break;
                    case 3:
                        letra = "C";
                        break;
                    case 4:
                        letra = "D";
                        break;
                    default:
                        break;
                }

                //Agregamos el Label
                Label lbl = new Label();
                //Detalles para crear el Label
                lbl.Font = new Font("Impact", 18);
                lbl.ForeColor = Color.FromArgb(248, 220, 51);
                lbl.Text = letra;
                lbl.Name = "lbl_Coord" + letra;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Dock = DockStyle.Fill;
                tbl_Coord.Controls.Add(lbl, 0, i);
            }

            
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            tbl_Coord.Controls.Clear();
            FillLabels();
            FillContent();
        }

        private void FillContent()
        {
            for (int i = 1; i < 6; i++)
            {

                for (char ch = 'A'; ch <= 'D'; ++ch)
                {
                    //Agregamos el Label
                    Label lbl = new Label();
                    //Detalles para crear el Label
                    lbl.Font = new Font("Impact", 18);
                    lbl.ForeColor = Color.White;
                    lbl.Text = ch.ToString() + i.ToString();
                    lbl.Name = "lbl_Content_" + ch.ToString() + i.ToString();
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    lbl.Dock = DockStyle.Fill;
                    tbl_Coord.Controls.Add(lbl, i, ch-64);
                }
                
            }
        }
    }
}
