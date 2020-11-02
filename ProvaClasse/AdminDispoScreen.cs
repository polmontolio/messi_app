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

namespace ProvaClasse
{
    public partial class AdminDispoScreen : BaseForm
    {
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

            devicevalidate = userData.DeviceValidation(txt_mac.Text, txt_hostname.Text);

            if (devicevalidate)
            {
                btn_save.Enabled = false;
                btn_delete.Enabled = true;
            }
            else
            {
                btn_save.Enabled = true;
                btn_delete.Enabled = true;
            }
        }
    }
}
