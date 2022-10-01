using CrudMVP._Repositories;
using CrudMVP.Models;
using CrudMVP.Presenters;
using CrudMVP.Views;
using System.Configuration;

namespace CrudMVP
{
  internal static class Program
  {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      // To customize application configuration such as set high DPI settings or default font,
      // see https://aka.ms/applicationconfiguration.
      ApplicationConfiguration.Initialize();
      string connStr = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString;

      /*
      IPetView view = new FormPetView();
      IPetRepository repository = new PetRepository(connStr);
      new PetPresenter(view, repository);

      //Application.Run((Form)view);
      */

      IMainView view = new MainView();
      new MainPresenter(view, connStr);
      Application.Run((Form)view);
    }
  }
}
