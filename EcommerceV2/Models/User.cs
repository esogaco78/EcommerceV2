using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EcommerceV2.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter email address")]
        [EmailAddress(ErrorMessage = "Enter a valid email address (example: foo@bar.com)")]
        public string Email { get; set; }

        [Display(Name = "Password (min 8 charicters, max 16)")]
        [Required(ErrorMessage = "Enter password")]
        [StringLength(16, ErrorMessage = "Password must be between 8 and 16 charicters long", MinimumLength = 8)]
        public string Password { get; set; }
    }
}