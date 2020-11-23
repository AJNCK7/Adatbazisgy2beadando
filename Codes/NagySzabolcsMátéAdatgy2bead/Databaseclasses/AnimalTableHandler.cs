using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace NagySzabolcsMátéAdatgy2bead
{
    class AnimalTableHandler : DatabaseConnection
    {
        public List<Animals> Select()
        {
            List<Animals> animals = new List<Animals>();

            OracleCommand command = new OracleCommand();
            command.Connection = connectionopen();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT animalid, animalname, animalbirthdate, animalgender, animalisneutered FROM animals";

            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Animals newanimal = new Animals();
                newanimal.Id = int.Parse(reader["id"].ToString());
                newanimal.AnimalName = (string)reader["animalname"];
                newanimal.BirthDate = (DateTime)reader["animalbirthdate"];
                newanimal.Neme = (string)reader["animalgender"];
                newanimal.Neutered = (byte)reader["animalisneutered"];

                animals.Add(newanimal);
            }
            reader.Close();
            return animals;
        }

        public int Delete(int number)
        {
            OracleCommand command = new OracleCommand();
            command.Connection = connectionopen();
            command.CommandType = System.Data.CommandType.Text;

            command.CommandText = "DELETE FROM animals WHERE animalid = :animalid";

            OracleParameter aId = new OracleParameter();
            aId.ParameterName = ":animalid";
            aId.OracleDbType = OracleDbType.Long;
            aId.Direction = System.Data.ParameterDirection.Input;
            aId.Value = number;
            command.Parameters.Add(aId);

            return command.ExecuteNonQuery();
        }

        public int Insert(Animals newanimal)
        {
            OracleCommand command = new OracleCommand();
            command.Connection = connectionopen();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "INSERT INTO animals(animalid, animalname, animalbirthdate, animalgender, animalisneutered)" +
                " VALUES(:animalid, :animalname, :animalbirthdate, :animalgender, :animalisneutered)";

            OracleParameter commandId = new OracleParameter();
            commandId.ParameterName = ":animalid";
            commandId.OracleDbType = OracleDbType.Int64;
            commandId.Direction = System.Data.ParameterDirection.Input;
            commandId.Value = newanimal.Id;

            OracleParameter commandName = new OracleParameter();
            commandName.ParameterName = ":animalname";
            commandName.OracleDbType = OracleDbType.Varchar2;
            commandName.Direction = System.Data.ParameterDirection.Input;
            commandName.Value = newanimal.AnimalName;

            OracleParameter commandBirthDate = new OracleParameter();
            commandBirthDate.ParameterName = ":animalbirthdate";
            commandBirthDate.OracleDbType = OracleDbType.Date;
            commandBirthDate.Direction = System.Data.ParameterDirection.Input;
            commandBirthDate.Value = newanimal.BirthDate;

            OracleParameter cGender = new OracleParameter();
            cGender.ParameterName = ":animalgender";
            cGender.OracleDbType = OracleDbType.Varchar2;
            cGender.Direction = System.Data.ParameterDirection.Input;
            cGender.Value = newanimal.Neme;

            OracleParameter cIsneutered = new OracleParameter();
            cIsneutered.ParameterName = ":animalisneutered";
            cIsneutered.OracleDbType = OracleDbType.Byte;
            cIsneutered.Direction = System.Data.ParameterDirection.Input;
            cIsneutered.Value = newanimal.Neutered;

            command.Parameters.Add(commandId);
            command.Parameters.Add(commandName);
            command.Parameters.Add(commandBirthDate);
            command.Parameters.Add(cGender);
            command.Parameters.Add(cIsneutered);

            return command.ExecuteNonQuery();
        }
    }
}
