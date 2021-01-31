using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project_Hospital
{
    class sql_Connection
    {
        public SqlConnection connect()
        {
            SqlConnection connection = new SqlConnection(System.IO.File.ReadAllText("connection.txt"));
            connection.Open();
            return connection;
        }
    }
}
