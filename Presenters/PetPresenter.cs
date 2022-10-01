using CrudMVP.Models;
using CrudMVP.Views;
using System.Drawing;

namespace CrudMVP.Presenters
{
  internal class PetPresenter
  {
    //Fields
    private IPetView view;
    private IPetRepository repository;
    private BindingSource petsBindingSource;
    private IEnumerable<PetModel> petList;

    //Constructor
    public PetPresenter(IPetView view, IPetRepository repository)
    {
      petsBindingSource = new();
      this.view = view;
      this.repository = repository;

      //Subscribe event handler methods to view events
      view.SearchEvent += SearchPet;
      view.AddNewEvent += AddNewPet;
      view.EditEvent += LoadSelectedPetToEdit;
      view.DeleteEvent += DeleteSelectedPet;
      view.SaveEvent += SavePet;
      view.CancelEvent += CancelAction;

      //Set pets bindind source
      view.SetPetListBindingSource(petsBindingSource);

      //Load pet list view
      LoadAllPetList();

      //Show view
      view.Show();
    }

    private void LoadAllPetList()
    {
      petList = repository.GetAll();
      petsBindingSource.DataSource = petList;
    }

    private void LoadSelectedPetToEdit(object? sender, EventArgs e)
    {
      PetModel pet = (PetModel)petsBindingSource.Current;
      view.PetId = pet.Id.ToString();
      view.PetName = pet.Name;
      view.PetColour = pet.Colour;
      view.PetType = pet.Type;
      view.IsEdit = true;
    }

    private void SavePet(object? sender, EventArgs e)
    {
      PetModel pet = new()
      {
        Id = Convert.ToUInt32(view.PetId),
        Name = view.PetName,
        Colour = view.PetColour,
        Type = view.PetType
      };

      try
      {
        new Common.ModelDataValidation().Validate(pet);
        if (view.IsEdit) //Edit pet
        {
          repository.Edit(pet);
          view.Message = "Pet edited sucessfuly";
        }
        else //Add new pet
        {
          repository.Add(pet);
          view.Message = "Pet added sucessfuly";
        }
        view.IsSuccessful = true;
        LoadAllPetList();
        CleanViewFields();
      }
      catch (Exception ex)
      {
        view.IsSuccessful = false;
        view.Message = ex.Message;
      }
    }

    private void CleanViewFields()
    {
      view.PetId = "0";
      view.PetName = "";
      view.PetColour = "";
      view.PetType = "";
    }

    private void CancelAction(object? sender, EventArgs e)
    {
      CleanViewFields();
    }

    private void AddNewPet(object? sender, EventArgs e)
    {
      view.IsEdit = false;
    }

    private void DeleteSelectedPet(object? sender, EventArgs e)
    {
      try
      {
        PetModel pet = (PetModel)petsBindingSource.Current;
        repository.Delete(pet.Id);
        view.IsSuccessful = true;
        view.Message = "Pet deleted sucessfuly";
        LoadAllPetList();
      } 
      catch (Exception ex)
      {
        view.IsSuccessful = false;
        view.Message = "An error ocurred, could not delete pet";
      }
    }

    private void SearchPet(object? sender, EventArgs e)
    {
      bool emptyValue = string.IsNullOrWhiteSpace(view.SearchValue);
      petList = !emptyValue ? repository.GetByValue(view.SearchValue) : repository.GetAll();
      petsBindingSource.DataSource = petList;
    }
  }
}
