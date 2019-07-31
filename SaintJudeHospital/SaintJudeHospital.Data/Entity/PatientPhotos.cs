using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SaintJudeHospital.Data.Entity
{
    public class PatientPhotos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { set; get; }
        public string Path { set; get; }
        public int? PatientId { set; get; }
        public bool IsPrimary { set; get; }
        public bool IsDeleted { set; get; }
        public virtual Patient Patient { set; get; }
    }
}
