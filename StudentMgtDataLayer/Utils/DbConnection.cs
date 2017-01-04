using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMgtDataLayer.Utils
{
    public static class DbConnection
    {
       // private static readonly string _connectionStr;
       
        public static SqlConnection CreateDbConnection()
        {
            return new SqlConnection();
        }
    }
}
