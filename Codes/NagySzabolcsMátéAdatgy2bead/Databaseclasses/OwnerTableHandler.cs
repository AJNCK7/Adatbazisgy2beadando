using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagySzabolcsMátéAdatgy2bead
{
    class OwnerTableHandler : DatabaseConnection
    {
        
        public List<Owners> Select()
        {
            List<Owners> owners = new List<Owners>();

            OracleCommand command = new OracleCommand();
            command.Connection = connectionopen();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT id, familyName, surName, birthDate FROM owners";

            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Owners newowner = new Owners();
                newowner.OwnerId = int.Parse(reader["id"].ToString());
                newowner.FamilyName = (string)reader["familyName"];
                newowner.Surname = (string)reader["surName"];
                newowner.BirthDate = (DateTime)reader["birthDate"];

                owners.Add(newowner);
            }
            reader.Close();
            return owners;
        }
    }
}
