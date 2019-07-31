using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SaintJudeHospital.Data.Entity
{
    public class InPatient
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { set; get; }
        public DateTime CreateDate { set; get; }
        public string Name { set; get; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { set; get; }
        public string Type { set; get; }
    }
}
