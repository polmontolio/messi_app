using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace User
{
    public class User
    {
        /**
        *
        **/
        private Database.SqlDatabase database;

        /**
         * 
         */ 
        public Boolean UserValidation(string username, string password) 
        {
            SqlConnection connection;

            //Declare the Database to connect
            this.database = new Database.SqlDatabase("DarkCore");
            connection = this.database.connectar();

            connection.Open();

            SqlCommand command = connection.CreateCommand();

            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT count(*) FROM [Users] " + "WHERE [codeuser] = @User" +
            " AND [password] = @Password";

            command.Parameters.Add(new SqlParameter("@User", username));
            command.Parameters.Add(new SqlParameter("@Password", password));

            int count = (int)command.ExecuteScalar();

            connection.Close();
            return count == 1;

        }

        public Boolean DeviceValidation(string mac, string hostname)
        {
            SqlConnection connection;

            //Declare the Database to connect
            this.database = new Database.SqlDatabase("DarkCore");
            connection = this.database.connectar();

            connection.Open();

            SqlCommand command = connection.CreateCommand();

            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT count(*) FROM [TrustedDevices] " + "WHERE [MAC] = @mac" +
            " AND [HostName] = @hostname";

            command.Parameters.Add(new SqlParameter("@mac", mac));
            command.Parameters.Add(new SqlParameter("@hostname", hostname));

            int count = (int)command.ExecuteScalar();

            connection.Close();
            return count == 1;
        }

        public int getDeviceID(string mac, string hostname)
        {
            SqlConnection connection;

            //Declare the Database to connect
            this.database = new Database.SqlDatabase("DarkCore");
            connection = this.database.connectar();

            connection.Open();

            SqlCommand command = connection.CreateCommand();

            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT idDevice FROM [TrustedDevices] " + "WHERE [MAC] = @mac" +
            " AND [HostName] = @hostname";

            command.Parameters.Add(new SqlParameter("@mac", mac));
            command.Parameters.Add(new SqlParameter("@hostname", hostname));

            int DeviceID = (int)command.ExecuteScalar();

            connection.Close();
            return DeviceID;
        }
        public int getUserID(string username, string password)
        {
            SqlConnection connection;

            //Declare the Database to connect
            this.database = new Database.SqlDatabase("DarkCore");
            connection = this.database.connectar();

            connection.Open();

            SqlCommand command = connection.CreateCommand();

            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT idUser FROM [Users] " + "WHERE [codeuser] = @User" +
            " AND [password] = @Password";

            command.Parameters.Add(new SqlParameter("@User", username));
            command.Parameters.Add(new SqlParameter("@Password", password));

            int idUser = (int)command.ExecuteScalar();

            connection.Close();
            return idUser;

        }

        public int getUserID(string username)
        {
            SqlConnection connection;

            //Declare the Database to connect
            this.database = new Database.SqlDatabase("DarkCore");
            connection = this.database.connectar();

            connection.Open();

            SqlCommand command = connection.CreateCommand();

            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT idUser FROM [Users] " + "WHERE [codeuser] = @User";

            command.Parameters.Add(new SqlParameter("@User", username));

            int idUser = (int)command.ExecuteScalar();

            connection.Close();
            return idUser;

        }

        public Boolean SettingsValidation(string username)
        {
            Boolean exist = false;
            try
            {
                var appSettings = System.Configuration.ConfigurationManager.AppSettings;
                string result = appSettings["TrustedUser"] ?? "Not Found";
                exist = result == username;
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
            return exist;
        }



        public Boolean UserDeviceValidation(string username, string password, string mac, string hostname)
        {

            int count;

            Boolean uservalidate = UserValidation(username, password);
            Boolean devicevalidate = DeviceValidation(mac, hostname);
            Boolean settingsvalidate = SettingsValidation(username);

            
            if (uservalidate && devicevalidate && settingsvalidate)
            {
                SqlConnection connection;

                //Declare the Database to connect
                this.database = new Database.SqlDatabase("DarkCore");
                connection = this.database.connectar();

                connection.Open();

                SqlCommand command = connection.CreateCommand();

                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT COUNT(*) FROM  MessiUsers mu, TrustedDevices td, Users u  " +
                    "WHERE u.idUser = mu.idUser and td.idDevice = mu.idDevice " +
                    "and u.codeUser = @username and u.password = @password " +
                    "and td.MAC = @mac and td.HostName = @hostname";


                command.Parameters.Add(new SqlParameter("@username", username));
                command.Parameters.Add(new SqlParameter("@password", password));
                command.Parameters.Add(new SqlParameter("@mac", mac));
                command.Parameters.Add(new SqlParameter("@hostname", hostname));

                count = (int)command.ExecuteScalar();

                connection.Close();
            } else
            {
                
                count = 0;
            }
            
            return count == 1;

        }

        public Boolean UserDeviceValidation(string username, string mac, string hostname)
        {

            SqlConnection connection;

            //Declare the Database to connect
            this.database = new Database.SqlDatabase("DarkCore");
            connection = this.database.connectar();

            connection.Open();

            SqlCommand command = connection.CreateCommand();

            command.CommandType = CommandType.Text;

            command.CommandText = "SELECT COUNT(*) FROM  MessiUsers mu, TrustedDevices td, Users u  " +
                "WHERE u.idUser = mu.idUser and td.idDevice = mu.idDevice " +
                "and u.codeUser = @username " +
                "and td.MAC = @mac and td.HostName = @hostname";


            command.Parameters.Add(new SqlParameter("@username", username));
            command.Parameters.Add(new SqlParameter("@mac", mac));
            command.Parameters.Add(new SqlParameter("@hostname", hostname));

            int count = (int)command.ExecuteScalar();



            connection.Close();

            return count == 1;

        }
        public string getValueCoordenada(string coordenada)
        {
            SqlConnection connection;

            //Declare the Database to connect
            this.database = new Database.SqlDatabase("DarkCore");
            connection = this.database.connectar();

            connection.Open();

            SqlCommand command = connection.CreateCommand();


            command.CommandText = "SELECT Value from AdminCoordinates WHERE Coordinate = @Coordenada";

            command.Parameters.Add(new SqlParameter("@Coordenada", coordenada));


            string value = command.ExecuteScalar().ToString();

            connection.Close();
            return value;
        }

        public void RegisterUserDevice(string username, string mac, string hostname)
        {

            int idUser = getUserID(username); 
            int idDevice = getDeviceID(mac, hostname);

            SqlConnection connection;

            //Declare the Database to connect
            this.database = new Database.SqlDatabase("DarkCore");
            connection = this.database.connectar();

            connection.Open();

            SqlCommand command = connection.CreateCommand();

            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO MessiUsers (idDevice, idUser) VALUES (@idDevice, @idUser) ";

            command.Parameters.Add(new SqlParameter("@idDevice", idDevice));
            command.Parameters.Add(new SqlParameter("@idUser", idUser));
          
            command.ExecuteScalar();

            connection.Close();
        }

        public void DeleteUserDevice(string username, string mac, string hostname)
        {

            int idUser = getUserID(username);
            int idDevice = getDeviceID(mac, hostname);

            SqlConnection connection;

            //Declare the Database to connect
            this.database = new Database.SqlDatabase("DarkCore");
            connection = this.database.connectar();

            connection.Open();

            SqlCommand command = connection.CreateCommand();

            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE MessiUsers where idDevice = @idDevice and idUser  = @idUser ";

            command.Parameters.Add(new SqlParameter("@idDevice", idDevice));
            command.Parameters.Add(new SqlParameter("@idUser", idUser));

            command.ExecuteScalar();

            connection.Close();
        }
    }
}
