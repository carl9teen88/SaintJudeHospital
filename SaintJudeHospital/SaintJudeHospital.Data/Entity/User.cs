using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SaintJudeHospital.Data.Entity
{
    public class User
    {
        public int UserId { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
        public int RoleId { set; get; }
        public Role Role { set; get; }
    }
}
