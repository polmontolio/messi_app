using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace ProvaClasse
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();

        }

        private void buttonCloseUs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuAd_Coordenadas_Click(object sender, EventArgs e)
        {
            AdminCoordScreen coordScreen = new AdminCoordScreen();
            coordScreen.Show();
            //this.Close();
            this.Hide();

        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("../font/SF Distant Galaxy.ttf");


            label1.Font = new Font(pfc.Families[0], 25, FontStyle.Regular);
            label2.Font = new Font(pfc.Families[0], 25, FontStyle.Regular);
            label3.Font = new Font(pfc.Families[0], 25, FontStyle.Regular);
        }

        private void menuAd_Dispositivos_Click(object sender, EventArgs e)
        {
            AdminDispoScreen dispoScreen = new AdminDispoScreen();
            dispoScreen.Show();
            //this.Close();
            this.Hide();


        }

        private void menuAd_Usuarios_Click(object sender, EventArgs e)
        {
            AdminGestionScreen gestionScreen = new AdminGestionScreen();
            gestionScreen.Show();
            //this.Close();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
