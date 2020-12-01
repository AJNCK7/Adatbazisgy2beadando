using System;
using Oracle.ManagedDataAccess.Client;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace NagySzabolcsMátéAdatgy2bead
{
    class OwnerTableHandler : DatabaseConnection
    {
     
        OracleConnection GetOracleConnection()
        {
            OracleConnection oc = new OracleConnection();
            string connectionString = @"Data Source = 193.225.33.71;User Id = ORA_S1340;Password = EKE2020;";
            oc.ConnectionString = connectionString;
            return oc;
        }
        public List<Owners> Select()
        {
            List<Owners> owners = new List<Owners>();

            OracleCommand command = new OracleCommand();
            command.Connection = connectionopen();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT id, familyname, surname, birthdate, zipcode, city, address, phonenumber, email FROM owners ORDER BY id ASC";

            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Owners newowner = new Owners();
                newowner.OwnerId = (string)reader["id"];
                newowner.FamilyName = (string)reader["familyname"];
                newowner.Surname = (string)reader["surname"];
                newowner.BirthDate = (DateTime)reader["birthdate"];
                newowner.ZipCode = (string)reader["zipcode"];
                newowner.City = (string)reader["city"];
                newowner.Address = (string)reader["address"];
                newowner.PhoneNumber = (string)reader["phonenumber"];
                newowner.Email = (string)reader["email"];
                owners.Add(newowner);
            }
            reader.Close();
            return owners;
        }


        public int Delete(string number)
        {
            OracleCommand command = new OracleCommand();
            command.Connection = connectionopen();
            command.CommandType = System.Data.CommandType.Text;

            command.CommandText = "DELETE FROM owners WHERE id = :id";

            OracleParameter oId = new OracleParameter();
            oId.ParameterName = ":id"; 
            oId.OracleDbType = OracleDbType.Varchar2;
            oId.Direction = System.Data.ParameterDirection.Input;
            oId.Value = number;
            command.Parameters.Add(oId);

            return command.ExecuteNonQuery();
        }

        public int Update(string number, string dataname, string data, OracleDbType oracleDbType)
        {
            OracleCommand command = new OracleCommand();
            command.Connection = connectionopen();
            command.CommandType = System.Data.CommandType.Text;

            switch (dataname)
            {
                case "familyName":
                    command.CommandText = "UPDATE owners SET familyname = :data WHERE id = :id";
                    break;
                case "surName":
                    command.CommandText = "UPDATE owners SET surname = :data WHERE id = :id";
                    break;
                case "zipCode":
                    command.CommandText = "UPDATE owners SET zipcode = :data WHERE id = :id";
                    break;
                case "city":
                    command.CommandText = "UPDATE owners SET city = :data WHERE id = :id";
                    break;
                case "address":
                    command.CommandText = "UPDATE owners SET address = :data WHERE id = :id";
                    break;
                case "phonenumber":
                    command.CommandText = "UPDATE owners SET phonenumber = :data WHERE id = :id";
                    break;
                case "email":
                    command.CommandText = "UPDATE owners SET email = :data WHERE id = :id";
                    break;
                default:
                    break;
            }
            
            
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
            OracleConnection oc = GetOracleConnection();
            oc.Open();

            OracleTransaction ot = oc.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "spinsert_owners"
            };

            /*OracleParameter idparameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_id",
                Direction = System.Data.ParameterDirection.Input,
                Value = newowner.OwnerId
            };
            command.Parameters.Add(idparameter);

            OracleParameter familynameparameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_familyname",
                Direction = System.Data.ParameterDirection.Input,
                Value = newowner.FamilyName
            };
            command.Parameters.Add(familynameparameter);

            OracleParameter surnameparamter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_surname",
                Direction = System.Data.ParameterDirection.Input,
                Value = newowner.Surname
            };

            command.Parameters.Add(surnameparamter);

            OracleParameter birthdateparameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_birthdate",
                Direction = System.Data.ParameterDirection.Input,
                Value = newowner.BirthDate
            };
            command.Parameters.Add(birthdateparameter);

            OracleParameter zipcodeparamter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_zipcode",
                Direction = System.Data.ParameterDirection.Input,
                Value = newowner.ZipCode
            };
            command.Parameters.Add(zipcodeparamter);

            OracleParameter cityparameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_city",
                Direction = System.Data.ParameterDirection.Input,
                Value = newowner.City
            };
            command.Parameters.Add(cityparameter);

            OracleParameter addressparameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_address",
                Direction = System.Data.ParameterDirection.Input,
                Value = newowner.Address
            };
            command.Parameters.Add(addressparameter);

            OracleParameter phonenumberparameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_phonenumber",
                Direction = System.Data.ParameterDirection.Input,
                Value = newowner.PhoneNumber
            };
            command.Parameters.Add(phonenumberparameter);

            OracleParameter emailparameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_email",
                Direction = System.Data.ParameterDirection.Input,
                Value = newowner.Email
            };
            command.Parameters.Add(emailparameter);*/

            //tartalékmegoldás
            #region getdatasfromtextboxes

            OracleParameter cid = new OracleParameter();
            cid.ParameterName = ":id";
            cid.OracleDbType = OracleDbType.Varchar2;
            cid.Direction = System.Data.ParameterDirection.Input;
            cid.Value = newowner.OwnerId;

            OracleParameter commandFName = new OracleParameter();
            commandFName.ParameterName = ":familyname";
            commandFName.OracleDbType = OracleDbType.Varchar2;
            commandFName.Direction = System.Data.ParameterDirection.Input;
            commandFName.Value = newowner.FamilyName;

            OracleParameter commandSName = new OracleParameter();
            commandSName.ParameterName = ":surname";
            commandSName.OracleDbType = OracleDbType.Varchar2;
            commandSName.Direction = System.Data.ParameterDirection.Input;
            commandSName.Value = newowner.Surname;

            OracleParameter cBirthDate = new OracleParameter();
            cBirthDate.ParameterName = ":birthdate";
            cBirthDate.OracleDbType = OracleDbType.Date;
            cBirthDate.Direction = System.Data.ParameterDirection.Input;
            cBirthDate.Value = newowner.BirthDate;

            OracleParameter cZipCode = new OracleParameter();
            cZipCode.ParameterName = ":zipcode";
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

            command.Parameters.Add(cid);
            command.Parameters.Add(commandFName);
            command.Parameters.Add(commandSName);
            command.Parameters.Add(cBirthDate);
            command.Parameters.Add(cZipCode);
            command.Parameters.Add(cCity);
            command.Parameters.Add(cAddress);
            command.Parameters.Add(cphonenumber);
            command.Parameters.Add(cemail);
            
            #endregion //tartalék megoldás

            OracleParameter rowcountPar = new OracleParameter()
            {
                DbType = System.Data.DbType.Int32,
                ParameterName = "p_out_rowcnt",
                Direction = System.Data.ParameterDirection.Output
            };
            command.Connection = oc;
            command.Transaction = ot;
            oc.Close();

            try
            {
                command.ExecuteNonQuery();
                int affectedRows = int.Parse(rowcountPar.Value.ToString());
                ot.Commit();
                return affectedRows;
            }
            catch (Exception)
            {
                ot.Rollback();
                return 0;
            }
        }

        public bool CheckPhonenumber(string phonenumber)
        {
            OracleConnection oc = GetOracleConnection();
            oc.Open();

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "sf_check_phonenumber"
            };

            OracleParameter correct = new OracleParameter()
            {
                DbType = System.Data.DbType.Int32,
                ParameterName = "p_out_result",
                Direction = System.Data.ParameterDirection.Output
            };

            OracleParameter phonenumberParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_phonenumber",
                Direction = System.Data.ParameterDirection.Input,
                Value = phonenumber

            };
            command.Parameters.Add(phonenumberParameter);

            command.Connection = oc;

            try
            {
                int succesful = int.Parse(correct.Value.ToString());

                return succesful != 0;
            }
            catch (Exception)
            {
                return false;
            }


        }

        public bool CheckZipCode(string zipcode)
        {

            OracleConnection oc = GetOracleConnection();
            oc.Open();

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "sf_check_zipcode"
            };

            OracleParameter correct = new OracleParameter()
            {
                DbType = System.Data.DbType.Int32,
                Direction = System.Data.ParameterDirection.ReturnValue
            };

            OracleParameter zipcodeParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_zipcode",
                Direction = System.Data.ParameterDirection.Input,
                Value = zipcode

            };
            command.Parameters.Add(zipcodeParameter);

            command.Connection = oc;
            try
            {
                int succesful = int.Parse(correct.Value.ToString());

                return succesful != 0;
            }
            catch (Exception)
            {
                return false;
            }


        }


    }
}
