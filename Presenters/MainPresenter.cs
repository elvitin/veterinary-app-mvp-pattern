using CrudMVP._Repositories;
using CrudMVP.Models;
using CrudMVP.Views;

namespace CrudMVP.Presenters
{
  internal class MainPresenter
  {
    private IMainView mainView;
    private readonly string connStr;

    public MainPresenter(IMainView mainView, string connStr)
    {
      this.mainView = mainView;
      this.connStr = connStr;
      this.mainView.ShowPetView += ShowPetsView;
    }

    private void ShowPetsView(object? sender, EventArgs e)
    {
      IPetView view = FormPetView.GetInstance((Form) mainView);
      IPetRepository repository = new PetRepository(connStr);
      new PetPresenter(view, repository);
    }
  }
}
