using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EcommerceV2.CustomValidation
{
    // Select all emails from the db, put into a list, check the value entered on the form
    // against all the emails in the list, if it matches throw a validation error.
    public class UniqueEmail: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var db = new DataAccess();
            List<string> emails = db.SelectAllUserEmails().ToList();
            foreach (string s in emails)
            {
                if (s == (string)value)
                {
                    return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
                }
            }
            return null;
        }
    }
}