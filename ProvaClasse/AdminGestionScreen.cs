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
    public partial class AdminGestionScreen : BaseForm
    {

        string userSelected;
        public AdminGestionScreen()
        {
            InitializeComponent();
            //Adjuntamos el enum al combobox
            cmbUser.DataSource = Enum.GetValues(typeof(User)).Cast<User>();
            
        }

        private void AdminGestionScreen_Load(object sender, EventArgs e)
        {

        }


        public enum User
        {
            User1,
            User2,
            User3
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

            //Guardamos el usuario seleccionado
            userSelected = cmbUser.SelectedItem.ToString();
            //txtMac.Text = userSelected;
        }
    }
}
