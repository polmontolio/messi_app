using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaClasse
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataManagement.StringData StringData = new DataManagement.StringData();
            DataManagement.intData intData = new DataManagement.intData();


            int numberRandom = intData.GenerateRandom(0, 9999);

            label1.Text = StringData.FillIntChar(numberRandom, 4, "0");


        }
    }
}
