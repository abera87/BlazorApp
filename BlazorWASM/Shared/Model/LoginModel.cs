using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWASM.Shared.Model
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Please enter email"),EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter password")]
        public string Password { get; set; }
    }
}
