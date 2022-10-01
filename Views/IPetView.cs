namespace CrudMVP.Views
{
  internal interface IPetView
  {
    string PetId { get; set; }
    string PetName { get; set; }
    string PetType { get; set; }
    string PetColour { get; set; }

    string SearchValue { get; set; }
    bool IsEdit { get; set; }
    bool IsSuccessful { get; set; }
    string Message { get; set; }

    event EventHandler SearchEvent;
    event EventHandler AddNewEvent;
    event EventHandler RemoveEvent;
    event EventHandler EditEvent;
    event EventHandler DeleteEvent;
    //event EventHandler DeleteAllEvent;
    //event EventHandler EditAllEvent;
    event EventHandler SaveEvent;
    event EventHandler CancelEvent;


    void SetPetListBindingSource(BindingSource petList);
    void Show();
  }
}
