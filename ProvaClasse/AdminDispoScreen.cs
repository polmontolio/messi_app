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
using User;
using Database;

namespace ProvaClasse
{
    public partial class AdminDispoScreen : BaseForm
    {
        User.User userData = new User.User();
        private Database.SqlDatabase database;
        String query;
        String _mac;
        String hostname;
        public AdminDispoScreen()
        {
            InitializeComponent();
        }

        private void AdminDispoScreen_Load(object sender, EventArgs e)
        {
            Boolean devicevalidate;
            NetworkUtilities.Machine machine = new NetworkUtilities.Machine();
            User.User userData = new User.User();

            txt_hostname.Text = machine.getHostname();
            txt_mac.Text = machine.getMAC();

            _mac = txt_mac.Text;
            hostname = txt_hostname.Text;

            devicevalidate = userData.DeviceValidation(_mac, hostname);

            if (devicevalidate)
            {
                btn_save.Enabled = false;
                btn_delete.Enabled = true;
            }
            else
            {
                btn_save.Enabled = true;
                btn_delete.Enabled = false;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            this.database = new Database.SqlDatabase("DarkCore");
            int DeviceID = userData.getDeviceID(_mac, hostname);

            query = "DELETE MessiUsers where idDevice = " + DeviceID + "; DELETE TrustedDevices where idDevice = " + DeviceID + ";";
            database.executa(query);
            btn_save.Enabled = true;
            btn_delete.Enabled = false;
            MessageBox.Show("Your device have been deleted correctly.");

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.database = new Database.SqlDatabase("DarkCore");
            

            query = "insert into TrustedDevices(MAC, HostName) values('" +_mac + "','" + hostname + "');";
            database.executa(query);
            btn_save.Enabled = false;
            btn_delete.Enabled = true;
            MessageBox.Show("Your device have been saved correctly.");
        }
    }
}
