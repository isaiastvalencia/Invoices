
using DEMO09.Types.Exceptions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DEMO09.Types
{
    public class TypeBase
    {
        public void Validate()
        {
            var context = new ValidationContext(this);
            var results = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(this, context, results, true);
            if (isValid == false)
            {
                throw new TypeValidationException();
            }
        }
    }
}
