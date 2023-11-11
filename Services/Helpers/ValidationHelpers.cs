
using System.ComponentModel.DataAnnotations;

namespace Services.Helpers
{
    public class ValidationHelpers
    {
        public static void ModelValidation(object obj)
        {
            //Mosel Validate Goods
            ValidationContext validationContext = new ValidationContext(obj);
            List<ValidationResult> validationResults = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(
                obj, validationContext, validationResults, true);
            if (!isValid)
            {
                throw new ArgumentException(validationResults.FirstOrDefault()?.ErrorMessage);
            }
        }
    }
}
