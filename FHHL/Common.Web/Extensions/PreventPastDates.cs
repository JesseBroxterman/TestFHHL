using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Web.Extensions
{

    public class PreventPastDatesAttribute : Attribute, IModelValidator, IClientModelValidator
    {
        public string ErrorMessage { get; set; } = "The entered date cannot be prior to the current date.";

        public void AddValidation(ClientModelValidationContext context)
        {
            context.Attributes.Add("data-val", "true");
            context.Attributes.Add("data-val-preventpast",
            ErrorMessage);
        }

        public IEnumerable<ModelValidationResult> Validate(ModelValidationContext context)
        {
            if (context.Model == null)
            {
                return Enumerable.Empty<ModelValidationResult>();
            }

            DateTime value = Convert.ToDateTime(context.Model);

            if (value.Date < DateTime.Now.Date)
            {
                return new List<ModelValidationResult>()
                {
                    new ModelValidationResult(context.ModelMetadata.PropertyName, ErrorMessage)
                };
            }
            else
            {
                return Enumerable.Empty<ModelValidationResult>();
            }
        }

    }
}
