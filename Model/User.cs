using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPC_Authentication.Model
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Birthdate { get; set; }
    }
}
