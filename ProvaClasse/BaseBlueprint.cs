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
    public partial class BaseBlueprint : Form
    {
        PanelOpacity panelOp = new PanelOpacity();
        public BaseBlueprint()
        {
            InitializeComponent();
        }

        private void BaseBlueprint_Load(object sender, EventArgs e)
        {

            pictureBox1.BackgroundImage = Image.FromFile("../img/death_star2.png");
            panelOp.Opacity = 20;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            panelOp.Opacity = 100;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("../img/Sith_canon.png");
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("../img/death_star2.png");

            
        }
    }
}
