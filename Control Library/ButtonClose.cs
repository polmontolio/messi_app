using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace Control_Library
{
    public partial class ButtonClose : UserControl
    {

        
        public ButtonClose()
        {
            InitializeComponent();
        }

        private void buttonCloseUs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
