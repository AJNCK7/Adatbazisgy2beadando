using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace NagySzabolcsMátéAdatgy2bead
{
    class DatabaseConnection
    {
        public OracleConnection connectionopen()
        {
            OracleConnection connection = new OracleConnection();

            string connectionstring = @"...";

            connection.ConnectionString = connectionstring;
            connection.Open();
            return connection;
        }
    }
}
