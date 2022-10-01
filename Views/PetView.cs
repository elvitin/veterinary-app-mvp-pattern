namespace CrudMVP.Views
{
  public partial class FormPetView : Form, IPetView
  {
    //Fields
    private string message;
    private bool isSuccessful;
    private bool isEdit;

    //Constructors
    public FormPetView()
    {
      InitializeComponent();
      AssociateAndRaiseViewEvents();
      TabControlPet.TabPages.Remove(TabPagePetDetail);
    }

    private void SwitchTabs(TabPage currentTab, TabPage hiddenTab)
    {
      TabControlPet.TabPages.Remove(currentTab);
      TabControlPet.TabPages.Add(hiddenTab);
    }

    private void AssociateAndRaiseViewEvents()
    {

      //Close form
      BtnClose.Click += delegate { this.Close(); };

      //Search register
      BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

      //Search register
      TxtBoxSearch.KeyDown += (s, e) =>
      {
        if (e.KeyCode == Keys.Enter)
        {
          //retira som do Enter
          //e.Handled = true;
          e.SuppressKeyPress = true;

          SearchEvent?.Invoke(this, EventArgs.Empty);
        }
      };

      //Add new register
      BtnAdd.Click += delegate
      {
        AddNewEvent?.Invoke(this, EventArgs.Empty);
        SwitchTabs(TabPagePetList, TabPagePetDetail);
        TabPagePetDetail.Text = "Add new pet";
      };

      //Edit register
      BtnEdit.Click += delegate
      {
        EditEvent?.Invoke(this, EventArgs.Empty);
        SwitchTabs(TabPagePetList, TabPagePetDetail);
        TabPagePetDetail.Text = "Edit pet";
      };

      //Save register
      BtnSave.Click += delegate
      {
        SaveEvent?.Invoke(this, EventArgs.Empty);
        if(isSuccessful)
          SwitchTabs(TabPagePetDetail, TabPagePetList);
        MessageBox.Show(Message);
      };

      //Delete register
      BtnDelete.Click += delegate
      {
        DialogResult result =  MessageBox.Show("Are you sure you want to delete the selected pet?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (result == DialogResult.Yes)
        {
          DeleteEvent?.Invoke(this, EventArgs.Empty);
          MessageBox.Show(Message);
        }
      };


      //Cancel register
      BtnCancel.Click += delegate
      {
        CancelEvent?.Invoke(this, EventArgs.Empty);
        SwitchTabs(TabPagePetDetail, TabPagePetList);
      };
    }

    //Properties
    public string PetId { get => TxtBoxPetID.Text; set => TxtBoxPetID.Text = value; }
    public string PetName { get => TxtBoxPetName.Text; set => TxtBoxPetName.Text = value; }
    public string PetType { get => TxtBoxPetType.Text; set => TxtBoxPetType.Text = value; }
    public string PetColour { get => TxtBoxPetColour.Text; set => TxtBoxPetColour.Text = value; }
    public string SearchValue { get => TxtBoxSearch.Text; set => TxtBoxSearch.Text = value; }
    public bool IsEdit { get => isEdit; set => isEdit = value; }
    public bool IsSuccessful { get => isSuccessful; set => isSuccessful = value; }
    public string Message { get => message; set => message = value; }

    public event EventHandler SearchEvent;
    public event EventHandler AddNewEvent;
    public event EventHandler RemoveEvent;
    public event EventHandler EditEvent;
    public event EventHandler DeleteEvent;
    public event EventHandler SaveEvent;
    public event EventHandler CancelEvent;

    public void SetPetListBindingSource(BindingSource petList)
    {
      DgvPet.DataSource = petList;
    }

    //Singleton pattern (Open a single form instance)
    private static FormPetView instance;

    public static FormPetView GetInstance(Form parentContainer)
    {
      if (instance == null || instance.IsDisposed)
      {
        instance = new();
        instance.MdiParent = parentContainer;
        instance.FormBorderStyle = FormBorderStyle.None;
        instance.Dock = DockStyle.Fill;
      }
      else
      {
        if (instance.WindowState == FormWindowState.Minimized)
          instance.WindowState = FormWindowState.Normal;

        instance.BringToFront();
      }

      return instance;
    }
  }
}
