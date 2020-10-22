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
            NetworkUtilities.Machine machine = new NetworkUtilities.Machine();

            txt_hostname.Text = machine.getHostname();
            txt_mac.Text = machine.getMAC();
        }
    }
}
