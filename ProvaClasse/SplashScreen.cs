using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Drawing.Text;

namespace ProvaClasse
{
    public partial class SplashScreen : Form
    {
        int porcentaje = 0;
        
        public SplashScreen()
        {
            InitializeComponent();
            

            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("../font/SF Distant Galaxy.ttf");
       
            lbl_titulo.Font = new Font(pfc.Families[0], 60, FontStyle.Regular);
            lbl_progressCarga.Font = new Font(pfc.Families[0], 15, FontStyle.Regular);
            lbl_progressCarga.Text = porcentaje + "%";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            timer1.Enabled = true;
            //timer1. Interval = 1000;
            timer1.Interval = 200;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value < 100){

                progressBar1.Value += 2;
                porcentaje += 2;
                lbl_progressCarga.Text = porcentaje + "%";

            } else {

                UserScreen UserScr = new UserScreen();
                timer1.Enabled = false;
                this.Hide();
                UserScr.Show();
                
                
            }
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void SplashScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.F2)

            {

                timer1.Stop();
                this.Hide();
                AdminScreen AdminScr = new AdminScreen();
                AdminScr.Show();
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
