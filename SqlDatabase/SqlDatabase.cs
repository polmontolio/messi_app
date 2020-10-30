using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using System.Runtime.InteropServices;
using System.Configuration;


namespace Database
{
    public class SqlDatabase
    {

        /**
         * The app connection string
         */ 
        private string connectionString;

        /**
        * SqlConnection
        */
        private SqlConnection connection;

        /**
         * Array of stored selects
         */ 
        private string[] selects;

        /**
        *
        **/
        private int selectsCounter;

        /**
         * 
         */ 
        private DataSet dataSet;

        /**
         * Constructor
         */
        public SqlDatabase(string connectionName)
        {
            this.connectionString = System.Configuration.ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;

            this.connection = new SqlConnection(this.connectionString);

            // initialize the array of procedures
            this.selects = new string[30];

            this.selectsCounter = 0;
        }

        /**
         *  Create a new sql database connection
         *  @params connectionString type string
         */
        public SqlConnection connectar()
        {
            this.connection = new SqlConnection(this.connectionString);
            return this.connection;
        }

        /**
         * From a table name of the database return all the data in a dataSet 
         */ 
        public DataSet portarTaula( string table)
        {
            SqlDataAdapter adapter;

            // Build a select
            string query;

            query = "SELECT * FROM " + table ;

            // add the query to the array
            this.addSelect(query);

            adapter = new SqlDataAdapter(query, this.connection);

            // Open the connection
            this.connection.Open();

            // Create new dataset
            DataSet dataSet = new DataSet();

            // fill dataset
            adapter.Fill(dataSet, table);

            // Close the connection
            this.connection.Close();

            // save the dataSet
            this.dataSet = dataSet;

            // return the dataset
            return dataSet;
        }

        /**
         * Update the dataset
         * Returns the number ob rows updated
         */
        public int actualitzar(DataSet dataset, string query)
        {
         
            try
            {
                // Open the connection
                this.connection.Open();
                // adapter
                SqlDataAdapter adapter;

                // TODO: explain
                adapter = new SqlDataAdapter(query, this.connection);

                SqlCommandBuilder cmdBuilder;

                cmdBuilder = new SqlCommandBuilder(adapter);

                // if the dataSet detects that has changes then update
                if (this.dataSet.HasChanges())
                {
                    int result = adapter.Update(dataSet.Tables[0]);

                    // Open the connection
                    this.connection.Close();

                    return result;
                }
                else
                {
                    // Open the connection
                    this.connection.Close();

                    return 0;
                }

            } catch(Exception ex)
            {
                Console.WriteLine("SqlDatabase executar exeption = ", ex);
                return 0;
            }
        }

        /**
         * 
         * 
         */ 
        public void executa(string query)
        {
            // Open the connection
            this.connection.Open();

            // create a new transaction using the connection
            SqlTransaction transaction = this.connection.BeginTransaction();

            try
            {
                // add the query to the array
                this.addSelect(query);

                // create a new command for then add a command text and a transaction
                SqlCommand command = this.connection.CreateCommand();

                // add the query inside the commandText
                command.CommandText = query;

                command.Transaction = transaction;

            } catch(Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine("SqlDatabase executar exeption = ", ex);
            } finally
            {
                // Close the connection
                this.connection.Close();
            }

        }



        /************************************************************
         * Encriptation functions
         ***********************************************************/

        /**
         * Encript the app conecion string
         * This function recibe a parameter called appName which is used to open the exe configuration file of the app
         */
        public void encriptarConnexio(string appName)
        {
            Configuration conf = ConfigurationManager.OpenExeConfiguration(appName + ".exe");
            ConnectionStringsSection section = conf.GetSection("connectionStrings")
            as ConnectionStringsSection;

            if (!section.SectionInformation.IsProtected)
            {
                section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
            }
            conf.Save();
        }



        /************************************************************
         * Overwrite functions
         ***********************************************************/

        /**
        * This function recibs a querry sql string and returns a dataset
        * 
        * Default dataset table name is: table
        */
        public DataSet portarPerConsultar(string sql)
        {
            SqlDataAdapter adapter;

            // add the query to the array
            this.addSelect(sql);

            adapter = new SqlDataAdapter(sql, this.connection);

            // Open the connection
            this.connection.Open();

            // Create new dataset
            DataSet dataSet = new DataSet();

            // fill dataset
            adapter.Fill(dataSet, "table");

            // Close the connection
            this.connection.Close();

            // save the dataSet
            this.dataSet = dataSet;

            // return the dataset
            return dataSet;
        }

        /**
        * This function recibs a querry sql string and returns a dataset with the given table name
        */
        public DataSet portarPerConsultar(string sql, string tableName)
        {
            SqlDataAdapter adapter;

            // add the query to the array
            this.addSelect(sql);

            adapter = new SqlDataAdapter(sql, this.connection);

            // Open the connection
            this.connection.Open();

            // Create new dataset
            DataSet dataSet = new DataSet();

            // fill dataset
            adapter.Fill(dataSet, tableName);

            // Close the connection
            this.connection.Close();

            // save the dataSet
            this.dataSet = dataSet;

            // return the dataset
            return dataSet;
        }


        /************************************************************
         * Private functions
         ***********************************************************/

        /**
         * Function for check if a procedure is added to the array
         */
        private Boolean isSelectAlreadyExist(string select)
        {
           return this.selects.Contains(select);
        }


        private void addSelect(string select)
        {
            // check if the procedure is inside of the array
            // if not then add it 
           if(!this.isSelectAlreadyExist(select))
            {   
                // increment the array counter positions
                this.selectsCounter++;

                if (this.selectsCounter < 30)
                {
                    this.selects[this.selectsCounter] = select;
                }
               
            }
        }
    }


}
