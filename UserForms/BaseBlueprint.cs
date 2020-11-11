using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserForms
{
    public partial class BaseBlueprint : Form
    {
        public BaseBlueprint()
        {
            InitializeComponent();
        }

        private void BaseBlueprint_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(26, 255, 0, 0);
        }
    }
}
