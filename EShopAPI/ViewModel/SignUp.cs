using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EShopAPI.ViewModel
{
    public class SignUp
    {

        [Required]
        public string UserName { get; set; }
        [Required]
        public string UserEmail { get; set; }

        [Required]
        public string UserPassword { get; set; }

     
    }
}
