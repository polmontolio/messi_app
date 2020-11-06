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
using DataManagement;

namespace ProvaClasse
{
    
    public partial class AdminGestionScreen : BaseForm
    {


        //CONSTRUCTORES
        NetworkUtilities.Machine machine = new NetworkUtilities.Machine();
        private Database.SqlDatabase database = new Database.SqlDatabase("DarkCore");
        User.User userData = new User.User();
        DataManagement.emailData emailData = new emailData();

        //DECLARACIONES
        String _mac;
        String hostname;
        string userSelected;

        public AdminGestionScreen()
        {
            InitializeComponent();
            
        }

        private void AdminGestionScreen_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnRegister.Enabled = false;

            hostname = machine.getHostname();
            _mac = machine.getMAC();

            txt_hostname.Text = hostname;
            txt_mac.Text = _mac;



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

            userSelected = cmbUser.Text;
            

            Boolean validatelogin = userData.UserDeviceValidation(userSelected, this._mac, this.hostname);

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
            String userEmail = userData.getUserEmail(userSelected);

            String existsUser = ConfigurationApp.Configuration.CheckUser("TrustedUser", userSelected);
            
            /*
            if (!userSelected.Equals(existsUser) && existsUser.Length > 0) {

                MessageBox.Show("This device is already connected to a user.");

            } else {

            }*/

            userData.RegisterUserDevice(userSelected, _mac, hostname);
            ConfigurationApp.Configuration.AddUpdateAppSettings("TrustedUser", userSelected);

            btnDelete.Enabled = false;
            btnRegister.Enabled = false;
            String body = "Your device (" + this.hostname + ") have been connected to your user account.";
            emailData.sendEmail(userEmail, "DEVICE REGISTERED " + userSelected.ToUpper(), body);
            MessageBox.Show("Your connection have been saved correctly. An email have been sent to the user.");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            ConfigurationApp.Configuration configApp = new ConfigurationApp.Configuration();
            userSelected = cmbUser.Text;
            String userEmail = userData.getUserEmail(userSelected);


            userData.DeleteUserDevice(userSelected, this._mac, this.hostname);
            ConfigurationApp.Configuration.DeleteAppSettings("TrustedUser");
            
            btnDelete.Enabled = false;
            btnRegister.Enabled = false;
            String body = "Your device (" + hostname + ") have been disconnected to your user account.";
            emailData.sendEmail(userEmail, "DEVICE DISCONNECTED " + userSelected.ToUpper(), body);
            MessageBox.Show("Your connection have been deleted correctly. An email have been sent to the user.");
        }
    }
}
