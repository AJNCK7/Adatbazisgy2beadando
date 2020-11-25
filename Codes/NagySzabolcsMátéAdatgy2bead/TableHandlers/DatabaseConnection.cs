using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Oracle.ManagedDataAccess.Client;

namespace NagySzabolcsMátéAdatgy2bead
{
    class DatabaseConnection
    {
        public OracleConnection connectionopen()
        {
            OracleConnection connection = new OracleConnection();

            string connectionstring = @"Data Source = 193.225.33.71;User Id = ORA_S1340;Password = EKE2020;";

            connection.ConnectionString = connectionstring;
            connection.Open();
            return connection;
        }
    }
}
