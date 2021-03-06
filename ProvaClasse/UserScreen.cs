﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Text;

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
            pfc.AddFontFile("../font/SF Distant Galaxy.ttf");
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
                MessageBox.Show("Access denied. Check your username or device. \n" + "Remaining attemps: " 
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
