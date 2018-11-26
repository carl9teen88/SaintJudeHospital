using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SaintJudeHospital.Data.Entity
{
    public class Medicine
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        public string GenericName { set; get; }
        public string Inscription { set; get; }
        public string Description { set; get; }
        public int? BrandId { set; get; }
        public Brand Brand { set; get; }
    }
}
