namespace CrudMVP.Models
{
  internal class PetModel
  {
    //Fields
    private uint id;
    private string name;
    private string type;
    private string colour;

    //Properties
    [System.ComponentModel.DisplayName("Pet ID")]
    public uint Id { get => id; set => id = value; }

    [System.ComponentModel.DisplayName("Pet Name")]
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pet name is requerid")]
    [System.ComponentModel.DataAnnotations.StringLength(50, MinimumLength = 3, ErrorMessage = "Pet name must be between 3 and 50 characters")]
    public string Name { get => name; set => name = value; }

    [System.ComponentModel.DisplayName("Pet Type")]
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pet type is requerid")]
    [System.ComponentModel.DataAnnotations.StringLength(50, MinimumLength = 3, ErrorMessage = "Pet type must be between 3 and 50 characters")]
    public string Type { get => type; set => type = value; }

    [System.ComponentModel.DisplayName("Pet Color")]
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Pet name is requerid")]
    [System.ComponentModel.DataAnnotations.StringLength(50, MinimumLength = 3, ErrorMessage = "Pet color must be between 3 and 50 characters")]
    public string Colour { get => colour; set => colour = value; }
  }
}
