namespace CrudMVP.Views
{
  internal interface IMainView
  {
    event EventHandler ShowPetView;
    event EventHandler ShowOwnerView;
    event EventHandler ShowVetsView;
  }
}
