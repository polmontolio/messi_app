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
            command.CommandText = "SELECT COUNT(*) FROM [Users] " + "WHERE [codeuser] = @User" +
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
            command.CommandText = "SELECT COUNT(*) FROM [TrustedDevices] " + "WHERE [MAC] = @mac" +
            " AND [HostName] = @hostname";

            command.Parameters.Add(new SqlParameter("@mac", mac));
            command.Parameters.Add(new SqlParameter("@hostname", hostname));

            int count = (int)command.ExecuteScalar();

            connection.Close();
            return count == 1;

        }

        public Boolean UserDeviceValidation(string mac, string hostname)
        {
            SqlConnection connection;

            //Declare the Database to connect
            this.database = new Database.SqlDatabase("DarkCore");
            connection = this.database.connectar();

            connection.Open();

            SqlCommand command = connection.CreateCommand();

            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT COUNT(*) FROM [TrustedDevices] " + "WHERE [MAC] = @mac" +
            " AND [HostName] = @hostname";

            command.Parameters.Add(new SqlParameter("@mac", mac));
            command.Parameters.Add(new SqlParameter("@hostname", hostname));

            int count = (int)command.ExecuteScalar();

            connection.Close();
            return count == 1;

        }

    }
}
