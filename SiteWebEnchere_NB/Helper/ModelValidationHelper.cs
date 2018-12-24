using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SiteWebEnchere_NB.Helper
{
    public static class ModelValidationHelper
    {
        public static List<ValidationResult> ValidBusinessModel(object obj)
        {
            try
            {
                var context = new ValidationContext(obj, null, null);
                var results = new List<ValidationResult>();
                Validator.TryValidateObject(obj, context, results, true);

                return results;
            }
            catch (Exception ex)
            {

                return new List<ValidationResult>() { new ValidationResult("Une erreur est survenue")};
            }
        }
    }
}