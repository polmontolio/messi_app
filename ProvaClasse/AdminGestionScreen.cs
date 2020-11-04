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
using User;

namespace ProvaClasse
{

    public partial class AdminGestionScreen : BaseForm
    {


        string userSelected;
        
        private Database.SqlDatabase database;
        String query;
        String _mac;
        String hostname;
        int idUser;
        int idDevice;
        public AdminGestionScreen()
        {
            InitializeComponent();
            //Adjuntamos el enum al combobox
            
            
        }

        private void AdminGestionScreen_Load(object sender, EventArgs e)
        {
            NetworkUtilities.Machine machine = new NetworkUtilities.Machine();
            User.User userData = new User.User();
            this.database = new Database.SqlDatabase("DarkCore");
            

            txt_hostname.Text = machine.getHostname();
            txt_mac.Text = machine.getMAC();


            _mac = txt_mac.Text;
            hostname = txt_hostname.Text;

            Boolean devicevalidate = userData.DeviceValidation(_mac, hostname);

            if (!devicevalidate)
            {
                ThreatScreen threatScreen = new ThreatScreen();
                threatScreen.ShowDialog();
            } else
            {
                cmbUser.DisplayMember = "codeUser";
                DataSet dataset = this.database.portarPerConsultar("select * from Users;", "Users");
                //We add this dataset to the controller
                cmbUser.DataSource = dataset.Tables[0];
            }
            
        }


        private void btnCheck_Click(object sender, EventArgs e)
        {
            NetworkUtilities.Machine machine = new NetworkUtilities.Machine();
            User.User userData = new User.User();
            this.database = new Database.SqlDatabase("DarkCore");

            hostname = machine.getHostname();
            _mac = machine.getMAC();
            userSelected = cmbUser.Text;

            //MessageBox.Show(userSelected);


            Boolean validatelogin = userData.UserDeviceValidation(userSelected, _mac, hostname);

            if (validatelogin)
            {
                btnDelete.Enabled = true;
                btnRegister.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = false;
                btnRegister.Enabled = true;
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            ConfigurationApp.Configuration configApp = new ConfigurationApp.Configuration();
            userSelected = cmbUser.Text;

            ConfigurationApp.Configuration.AddUpdateAppSettings("TrustedUser", userSelected);

        }
    }
}
