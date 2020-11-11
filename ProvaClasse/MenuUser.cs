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
            Assembly ensamblat = Assembly.LoadFrom(@"UserForms.dll");
            Object dllBD;
            Type tipus;
            tipus = ensamblat.GetType("UserForms.BaseBlueprint");
            dllBD = Activator.CreateInstance(tipus);
            ((Form)dllBD).Show();
        }
    }
}
