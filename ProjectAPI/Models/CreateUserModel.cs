using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Models
{
    public class CreateUserModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}