namespace CrudMVP.Views
{
  public partial class MainView : Form, IMainView
  {
    public MainView()
    {
      InitializeComponent();
      BtnPets.Click += delegate { ShowPetView?.Invoke(this, EventArgs.Empty); };
    }

    public event EventHandler ShowPetView;
    public event EventHandler ShowOwnerView;
    public event EventHandler ShowVetsView;

    private void BtnOwners_Click(object sender, EventArgs e)
    {

    }
  }
}
