using SharedConfig.Messages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidationLayer.Validators
{
    // Validate email address such as karim.elzarkany@te.eg
    public class RequiredValidator : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            ErrorMessage = Errors.E_SOMETHING_WENT_WRONG;

            // Required validation will be separated
            if (value != null && !string.IsNullOrEmpty(value.ToString()))
                return true;
            return false;
        }
    }
}
