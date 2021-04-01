using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProject.Models
{
    public class User
    {
        public User(List<Role> roles)
        {
            this.Roles = roles;
        }
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public List<Role> Roles { get; set; }
    }
}
