using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;
using System.Drawing.Text;
using NetworkUtilities;

namespace ProvaClasse
{
    public partial class UserScreen : Form
    {

        int intentos = 0;
        NetworkUtilities.Machine machine = new NetworkUtilities.Machine();
        String _MAC;
        String hostname;
    public UserScreen()
        {
            InitializeComponent();



            _MAC = machine.getMAC();
            hostname= machine.getHostname();

            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCloseUs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UsenScreen_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            //pfc.AddFontFile("C:/Users/pol/Desktop/MESSI/SolucioProva/font/SF Distant Galaxy.ttf");
            //pfc.AddFontFile("D:/AAS2AM/MESSI/SolucioProva/font/SF Distant Galaxy.ttf");
            pfc.AddFontFile("E:/Messi_app/SolucioProva/font/SF Distant Galaxy.ttf");
            //pfc.AddFontFile("C:/Users/pol/Desktop/MESSI/messi_app/font/SF Distant Galaxy.ttf");
            lbl_user_title.Font = new Font(pfc.Families[0], 35, FontStyle.Regular);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            User.User userData = new User.User();

            
            //Creamos variables
            String username = txt_username.Text;
            String password = mtxt_password.Text;
        
            Boolean validatelogin = userData.UserDeviceValidation(username, password, _MAC, hostname);


            DateTime datetime = DateTime.Now;
            string fecha_actual = datetime.ToString("yyyyMMdd:HHmmss");


            if (validatelogin)
            {
                this.Hide();
                MenuUser MenuUser = new MenuUser();
                MenuUser.Show();
            } else
            {
                intentos++;
                MessageBox.Show("Acceso denegado. Compruebe su usuario y/o dispositivos. \n" + "Intentos restantes: " 
                    + (3 - intentos).ToString());

                if (intentos >= 3)
                {
                    //Imprime un log.
                    string log_errorUser = fecha_actual + ":" + username;
                    //MessageBox.Show(log_errorUser);
                    WriteLog(log_errorUser);

                    //Abrir nuevo formulario con mensaje AMENAZADDOR
                    ThreatScreen threatScreen = new ThreatScreen();
                    //threatScreen.Show();
                    threatScreen.ShowDialog();
                }

            }

            

        }


        public static void WriteLog(string logline)
        {
            string path = "C:/Users/Karol/Desktop/";
            
            string fileName = "log_error.log";
            try
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(path + fileName, true);
                file.WriteLine(logline);
                file.Close();
            }
            catch (Exception) { }
        }

        private void lbl_Username_Click(object sender, EventArgs e)
        {

        }

        private void mtxt_password_KeyDown(object sender, KeyEventArgs e)
        {
            //PRESS ENTER == PRESS BTN LOGIN
            if (e.KeyCode == Keys.Enter)
            {
                btn_login_Click(null, null);
            }
        }

        private void txt_username_KeyDown(object sender, KeyEventArgs e)
        {
            //PRESS ENTER == PRESS BTN LOGIN & CONDITIONS
            if (e.KeyCode == Keys.Enter && mtxt_password.Text.Length > 0)
            {
                btn_login_Click(null, null);
            }
        }
    }
}
