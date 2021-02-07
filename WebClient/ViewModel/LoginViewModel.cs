using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebClient.ViewModel
{
    public class LoginViewModel
    {
        [Required]
        public string UserEmail { get; set; }
        [Required]
        public string Password { get; set; }

    }
}
