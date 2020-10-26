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
using NetworkUtilities;
using ConfigurationApp;
using System.Configuration;

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
            NetworkUtilities.Machine machine = new NetworkUtilities.Machine();

            txt_hostname.Text = machine.getHostname();
            txt_mac.Text = machine.getMAC();

        }


        public enum User
        {
            User1,
            User2,
            User3
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            ConfigurationApp.Configuration configApp = new ConfigurationApp.Configuration();
            userSelected = cmbUser.SelectedItem.ToString();

            ConfigurationApp.Configuration.AddUpdateAppSettings("TrustedUser", userSelected);

        }
    }
}
