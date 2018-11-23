using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SaintJudeHospital.Data.Entity
{
    public class Role
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoleId { set; get; }
        public string Name { set; get; }
    }
}
