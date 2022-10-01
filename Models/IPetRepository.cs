namespace CrudMVP.Models
{
  internal interface IPetRepository
  {
    void Add(PetModel petModel);
    void Edit(PetModel petModel);
    //void Delete(PetModel petModel);
    void Delete(uint id);
    IEnumerable<PetModel> GetAll();
    IEnumerable<PetModel> GetByValue(string value);
    //IEnumerable<PetModel> FindAll();
    //IEnumerable<PetModel> FindByName(string name);
    //IEnumerable<PetModel> FindById(int id);
  }
}
