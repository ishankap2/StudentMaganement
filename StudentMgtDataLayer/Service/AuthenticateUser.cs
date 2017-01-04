using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMgtDataLayer.Service
{
    public class AuthenticateUser
    {
        private readonly SqlConnection _sqlConnection;
        public readonly string _userName;
        public readonly string _password;

        public AuthenticateUser(SqlConnection dbConn, string userName, string password)
        {
            _sqlConnection = dbConn;
            _userName = userName;
            _password = password;
        }

        public bool AthuenticateUser()
        {
            return true;
        }

    }
}
