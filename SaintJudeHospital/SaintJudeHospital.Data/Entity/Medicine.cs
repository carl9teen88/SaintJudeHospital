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

        public int GenericId { set; get; }
        public virtual Generic Generic { set; get; }
        public int? InscriptionId { set; get; }
        public virtual Inscription Inscription { set; get; }
        public string Description { set; get; }
        public int? BrandId { set; get; }
        public Brand Brand { set; get; }
    }
}
