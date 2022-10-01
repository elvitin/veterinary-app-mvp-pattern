using CrudMVP.Models;
using MySql.Data.MySqlClient;

namespace CrudMVP._Repositories
{
  internal class PetRepository : BaseRepository, IPetRepository
  {
    //Constructor
    public PetRepository(string connectionString)
    {
      this.connectionString = connectionString;
    }

    //Methods
    public void Add(PetModel petModel)
    {
      WrapperMySQL mysql = new(this.connectionString);
      try
      {
        mysql.Command.CommandText = $"INSERT INTO pet (pet_name, pet_type, pet_colour) values ('{petModel.Name}', '{petModel.Type}', '{petModel.Colour}');";
        mysql.OpenConnection();
        mysql.Command.ExecuteNonQuery();
        Console.WriteLine("Query: " + mysql.Command.CommandText);
      }
      catch (Exception)
      {
        throw;
      }
      finally
      {
        mysql.CloseConnection();
      }
    }

    public void Edit(PetModel petModel)
    {
      WrapperMySQL mysql = new(this.connectionString);
      try
      {
        mysql.Command.CommandText = $@"UPDATE pet SET pet_name = '{petModel.Name}', pet_type = '{petModel.Type}', pet_colour = '{petModel.Colour}' WHERE pet_id = {petModel.Id};";
        mysql.OpenConnection();
        mysql.Command.ExecuteNonQuery();
        Console.WriteLine("Query: " + mysql.Command.CommandText);
      }
      catch (Exception)
      {
        throw;
      }
      finally
      {
        mysql.CloseConnection();
      }
    }

    public void Delete(uint id)
    {
      WrapperMySQL mysql = new(this.connectionString);
      try
      {
        mysql.Command.CommandText = $"DELETE FROM pet WHERE pet_id = {id};";
        mysql.OpenConnection();
        mysql.Command.ExecuteNonQuery();
        Console.WriteLine("Query: " + mysql.Command.CommandText);
      }
      catch (Exception)
      {
        throw;
      }
      finally
      {
        mysql.CloseConnection();
      }
    }

    public IEnumerable<PetModel> GetAll()
    {
      List<PetModel> petList = new();
      using (MySqlConnection connection = new(this.connectionString))
      using (MySqlCommand command = new())
      {
        connection.Open();
        command.Connection = connection;
        command.CommandText = "SELECT * FROM pet ORDER BY pet_id DESC";
        using (MySqlDataReader reader = command.ExecuteReader())
        {
          while (reader.Read())
          {
            petList.Add(new()
            {
              Id = (uint)reader["pet_id"],
              Name = reader["pet_name"].ToString(),
              Type = reader["pet_type"].ToString(),
              Colour = reader["pet_colour"].ToString()
            });
          }
        }
      }
      return petList;

      /*
      List<PetModel> petList = new();
      WrapperMySQL mysql = new(this.connectionString);
      try
      {
        mysql.Command.CommandText = "SELECT * FROM pet ORDER BY pet_id DESC";
        mysql.OpenConnection();
        MySqlDataReader result = mysql.Command.ExecuteReader();
        while (result.Read())
        {
          petList.Add(new()
          {
            Id = (int)result["pet_id"],
            Name = (string)result["pet_name"],
            Type = (string)result["pet_type"],
            Colour = (string)result["pet_colour"]
          });
        }
      }
      catch (Exception)
      {
        throw;
      }
      finally
      {
        mysql.CloseConnection();
      }
      return petList;
      */
    }

    public IEnumerable<PetModel> GetByValue(string value)
    {
      List<PetModel> petList = new();
      using (MySqlConnection connection = new(this.connectionString))
      using (MySqlCommand command = new())
      {
        connection.Open();
        command.Connection = connection;
        command.CommandText = @"SELECT * FROM pet WHERE pet_id = @id OR pet_name LIKE @name ORDER BY pet_id DESC";

        uint petId = uint.TryParse(value, out _) ? Convert.ToUInt32(value) : 0;
        string petName = value;
        command.Parameters.Add("@id", MySqlDbType.UInt32).Value = petId;
        command.Parameters.Add("@name", MySqlDbType.VarChar).Value = petName + '%';

        using MySqlDataReader reader = command.ExecuteReader();
        Console.WriteLine("Query: " + command.CommandText);
        while (reader.Read())
        {
          petList.Add(new()
          {
            Id = (uint)reader["pet_id"],
            Name = reader["pet_name"].ToString(),
            Type = reader["pet_type"].ToString(),
            Colour = reader["pet_colour"].ToString()
          });
        }
      }
      return petList;
    }
  }
}
