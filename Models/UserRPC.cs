using System;
using System.ComponentModel.DataAnnotations;

namespace RPC_Authentication.Models
{
    public class UserRPC
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name ="User Name")]
        public string Username { get; set; }
        public string Password { get; set; }
        public String Firstname { get; set; }
        public String Lastname { get; set; }
    }
}
