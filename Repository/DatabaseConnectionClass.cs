using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Repository
{
    class DatabaseConnectionClass
    {
        private SqlConnection myConnection;
        private SqlCommand myCommand;

        public DatabaseConnectionClass()
        {
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\INTER_WAVE\Desktop\New folder (2)\UMS V1.3.Raihan.Nadim\UMS V1.2.Raihan.Nadim\Repository\UMSDatabase.mdf;Integrated Security=True";
            myConnection = new SqlConnection(connectionString);
        }

        public void ConnectWithDB()
        {
            myConnection.Open();
        }
        public void CloseConnection()
        {
            myConnection.Close();
        }

        public SqlDataReader GetData(string query)
        {
            myCommand = new SqlCommand(query, myConnection);
            //SqlDataReader sdr = myCommand.ExecuteReader();
            //return sdr;
            return myCommand.ExecuteReader();
        }
        public int ExecuteSQL(string query)
        {
            myCommand = new SqlCommand(query, myConnection);
            //int x= myCommand.ExecuteNonQuery();
            //return x;
            return myCommand.ExecuteNonQuery();
        }
    }
}
