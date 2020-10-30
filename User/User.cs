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
            this.database = new Database.SqlDatabase("SecureCode");
            connection = this.database.connectar();

            connection.Open();

            SqlCommand command = connection.CreateCommand();

            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT COUNT(*) FROM [Users] " + "WHERE [codeuser] = @User" +
            " AND [Password] = @Password";

            command.Parameters.Add(new SqlParameter("@User", username));
            command.Parameters.Add(new SqlParameter("@Password", password));

            int count = (int)command.ExecuteScalar();

            connection.Close();
            return count == 1;

        }

        public DataSet getMenu(int userRank, int menuId)
        {
            this.database = new Database.SqlDatabase("SecureCode");
            string query = "select m.menu_id, m.menu_name,b.boton_id,b.boton_desc,b.boton_formOpen from Menus m, Botones b, MenuRanks r where m.menu_id = b.menu_id and b.boton_id = r.boton_id and m.menu_id = 1 and r.rank_id = 1";

            DataSet dataset = this.database.portarPerConsultar(query, "menu");


            return dataset;

        }
    }
}
