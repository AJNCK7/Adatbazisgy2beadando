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
            command.CommandText = "SELECT id, familyName, surName, birthDate, zipCode, city, address, phonenumber, email FROM owners";

            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Owners newowner = new Owners();
                newowner.OwnerId = int.Parse(reader["id"].ToString());
                newowner.FamilyName = (string)reader["familyName"];
                newowner.Surname = (string)reader["surName"];
                newowner.BirthDate = (DateTime)reader["birthDate"];
                newowner.ZipCode = (string)reader["zipCode"];
                newowner.City = (string)reader["city"];
                newowner.Address = (string)reader["address"];
                newowner.PhoneNumber = (string)reader["phonenumber"];
                newowner.Email = (string)reader["email"];
                owners.Add(newowner);
            }
            reader.Close();
            return owners;
        }


        public int Delete(int number)
        {
            OracleCommand command = new OracleCommand();
            command.Connection = connectionopen();
            command.CommandType = System.Data.CommandType.Text;

            command.CommandText = "DELETE FROM owners WHERE id = :id";

            OracleParameter oId = new OracleParameter();
            oId.ParameterName = ":id"; 
            oId.OracleDbType = OracleDbType.Long; 
            oId.Direction = System.Data.ParameterDirection.Input;
            oId.Value = number;
            command.Parameters.Add(oId);

            return command.ExecuteNonQuery();
        }

        public int Update(int number, string dataname, string data, OracleDbType oracleDbType)
        {
            OracleCommand command = new OracleCommand();
            command.Connection = connectionopen();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "UPDATE owners SET :dataname = :data WHERE id = :id";

            OracleParameter odataname = new OracleParameter();
            odataname.ParameterName = ":dataname";
            odataname.OracleDbType = OracleDbType.Char;
            odataname.Direction = System.Data.ParameterDirection.Input;
            odataname.Value = "surName";
            command.Parameters.Add(odataname);

            OracleParameter odata = new OracleParameter();
            odata.ParameterName = ":data";
            odata.OracleDbType = oracleDbType;
            odata.Direction = System.Data.ParameterDirection.Input;
            odata.Value = data;
            command.Parameters.Add(odata);

            OracleParameter oId = new OracleParameter();
            oId.ParameterName = ":id";
            oId.OracleDbType = OracleDbType.Int64;
            oId.Direction = System.Data.ParameterDirection.Input;
            oId.Value = number;
            command.Parameters.Add(oId);

            return command.ExecuteNonQuery();
        }

        public int Insert(Owners newowner)
        {
            OracleCommand command = new OracleCommand();
            command.Connection = connectionopen();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "INSERT INTO owners(id, familyName, surName, birthDate, zipCode, city, address, phonenumber, email)" +
                " VALUES(:id, :familyName, :surName, :birthDate, :zipCode, :city, :address, :phonenumber, :email)";

            OracleParameter commandId = new OracleParameter();
            commandId.ParameterName = ":id";
            commandId.OracleDbType = OracleDbType.Int64;
            commandId.Direction = System.Data.ParameterDirection.Input;
            commandId.Value = newowner.OwnerId;

            OracleParameter commandFName = new OracleParameter();
            commandFName .ParameterName = ":familyName";
            commandFName .OracleDbType = OracleDbType.Varchar2;
            commandFName .Direction = System.Data.ParameterDirection.Input;
            commandFName.Value = newowner.FamilyName;

            OracleParameter commandSName = new OracleParameter();
            commandSName .ParameterName = ":surName";
            commandSName .OracleDbType = OracleDbType.Varchar2;
            commandSName .Direction = System.Data.ParameterDirection.Input;
            commandSName.Value = newowner.Surname;

            OracleParameter cBirthDate = new OracleParameter();
            cBirthDate.ParameterName = ":birthDate";
            cBirthDate.OracleDbType = OracleDbType.Date;
            cBirthDate.Direction = System.Data.ParameterDirection.Input;
            cBirthDate.Value = newowner.BirthDate;

            OracleParameter cZipCode = new OracleParameter();
            cZipCode.ParameterName = ":zipCode";
            cZipCode.OracleDbType = OracleDbType.Varchar2;
            cZipCode.Direction = System.Data.ParameterDirection.Input;
            cZipCode.Value = newowner.ZipCode;

            OracleParameter cCity = new OracleParameter();
            cCity.ParameterName = ":city";
            cCity.OracleDbType = OracleDbType.Varchar2;
            cCity.Direction = System.Data.ParameterDirection.Input;
            cCity.Value = newowner.City;

            OracleParameter cAddress = new OracleParameter();
            cAddress.ParameterName = ":address";
            cAddress.OracleDbType = OracleDbType.Varchar2;
            cAddress.Direction = System.Data.ParameterDirection.Input;
            cAddress.Value = newowner.Address;

            OracleParameter cphonenumber = new OracleParameter();
            cphonenumber.ParameterName = ":phonenumber";
            cphonenumber.OracleDbType = OracleDbType.Varchar2;
            cphonenumber.Direction = System.Data.ParameterDirection.Input;
            cphonenumber.Value = newowner.PhoneNumber;

            OracleParameter cemail = new OracleParameter();
            cemail.ParameterName = ":email";
            cemail.OracleDbType = OracleDbType.Varchar2;
            cemail.Direction = System.Data.ParameterDirection.Input;
            cemail.Value = newowner.Email;

            command.Parameters.Add(commandId);
            command.Parameters.Add(commandFName);
            command.Parameters.Add(commandSName);
            command.Parameters.Add(cBirthDate);
            command.Parameters.Add(cZipCode);
            command.Parameters.Add(cCity);
            command.Parameters.Add(cAddress);
            command.Parameters.Add(cphonenumber);
            command.Parameters.Add(cemail);

            return command.ExecuteNonQuery();
        }
    }
}
