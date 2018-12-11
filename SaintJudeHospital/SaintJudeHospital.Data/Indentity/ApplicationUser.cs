using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaintJudeHospital.Data.Indentity
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public bool IsDelete { set; get; }
        public DateTime CreatedDate { set; get; }
        public int? CreateBy { set; get; }
    }
}
