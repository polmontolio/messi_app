using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace ProvaClasse
{
    public partial class MenuUser : Form
    {
        public MenuUser()
        {
            InitializeComponent();

            
        }

        private void buttonCloseUs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuUser_Load(object sender, EventArgs e)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            StarKiller.Form1 form = new StarKiller.Form1();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StarKillerBase.Server form = new StarKillerBase.Server();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BalisesActives.Naivgation form = new BalisesActives.Naivgation();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BalisesPassives.Form1 form = new BalisesPassives.Form1();
            form.Show();
            this.Hide();
        }
    }
}
