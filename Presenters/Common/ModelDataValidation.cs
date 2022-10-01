using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CrudMVP.Presenters.Common
{
  internal class ModelDataValidation
  {
    public void Validate(object model)
    {
      StringBuilder errorMessage = new();
      List<ValidationResult> errors = new();
      ValidationContext context = new(model);
      bool isValid = Validator.TryValidateObject(model, context, errors, true);
      if (!isValid)
      {
        foreach (var error in errors)
        {
          errorMessage.AppendLine(error.ErrorMessage);
        }
        throw new(errorMessage.ToString());
      }
    }
  }
}
