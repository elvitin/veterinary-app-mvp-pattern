using MySql.Data.MySqlClient;

namespace CrudMVP._Repositories
{
  internal class WrapperMySQL
  {
    private MySqlConnection Connection { get; set; }
    public MySqlCommand Command { get; set; }

    public WrapperMySQL(string connectionString)
    {
      string strCon = connectionString;
      Connection = new MySqlConnection(strCon);
      Command = Connection.CreateCommand();
    }

    public void OpenConnection()
    {
      if (Connection.State != System.Data.ConnectionState.Open)
        Connection.Open();
    }

    public void CloseConnection()
    {
      if (Connection.State != System.Data.ConnectionState.Closed)
        Connection.Close();
    }
  }
}
