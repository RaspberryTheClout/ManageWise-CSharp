using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Neth_Mobiles_Management_System
{
    internal class sqlconnection
    {
        private MySqlConnection connection;
        private string connectionString;


        // Constructor
        public sqlconnection()
        {
            //connection string
            connectionString = $"Server=localhost;Database=NethMobile;User ID='root';Password=''";
            connection = new MySqlConnection(connectionString);
        }

        // Open connection to the database
        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        // Close the connection to the database
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        // Get the MySQLConnection object for manual operations
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
