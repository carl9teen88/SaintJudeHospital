using System;
using System.Collections.Generic;
using System.Text;

namespace SaintJudeHospital.Data.Entity
{
    public class Parent
    {
        public int ParentId { set; get; }
        public int Age { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Occupation { set; get; }
    }
}
