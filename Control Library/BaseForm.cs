using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Library
{
    public partial class BaseForm: Form
    {


        public BaseForm()
        {
            InitializeComponent();

            
        }



        private void buttonClose1_Click(object sender, EventArgs e)
        {

        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }

        public string Texto
        {
            get { return lbl_titulo.Text; }
            set { lbl_titulo.Text = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formContainer = FindForm();
            MessageBox.Show("Click");


            System.Reflection.Assembly _asm = System.Reflection.Assembly.GetExecutingAssembly();
            //Create the instance of the form
            var _frm = (Form)_asm.CreateInstance("SecureCode" + "." + "MenuAdmin");

            _frm.Show();
            formContainer.Hide();

        }
    }
}
