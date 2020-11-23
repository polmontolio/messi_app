using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;

namespace ProvaClasse
{
    public partial class SpaceshipTechnical : Control_Library.BaseForm
    {
        public SpaceshipTechnical()
        {
            InitializeComponent();
        }

        private void SpaceshipTechnical_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("../font/SF Distant Galaxy.ttf");
            lbl_fija.Font = new Font(pfc.Families[0], 18, FontStyle.Regular);
            lbl_fija2.Font = new Font(pfc.Families[0], 18, FontStyle.Regular);
        }
    }
}
