using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class RegisterDto
    {
        //The Required property is to make sure the actually enter in a username or password. Hence, it won't let the user create a username with an empty string
        [Required]
        public string Username {get; set;}

        [Required]
        public string Password {get; set;}
    }
}