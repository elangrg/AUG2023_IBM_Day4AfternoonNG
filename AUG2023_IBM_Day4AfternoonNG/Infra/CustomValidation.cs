using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace AUG2023_IBM_Day4AfternoonNG.Infra
{

    public class OnlyAlphaAttribute : RegularExpressionAttribute
    {
        public OnlyAlphaAttribute() : base("[A-Za-z]*")
        {

        }


    }


    public class MustContainPrjTypeAttribute : ValidationAttribute,
 IClientModelValidator
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string Prjdesc = value.ToString();

            if (!Prjdesc.Contains("Project Type"))
            {
                return new ValidationResult("Project Desc must Cointain [Project Type] Info");
            }
            return ValidationResult.Success;
        }
        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val", "true");
            context.Attributes.Add("data-val-PrjdescMustHave",
            "Project Desc must Cointain [Project Type] Info");
        }
    }


}
