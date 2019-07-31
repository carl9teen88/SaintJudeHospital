using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SaintJudeHospital.Data.Entity
{
    public class Bill
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { set; get; }
        public int CheckupId { set; get; }
        public virtual Checkup Checkup {set; get;}
        public int PatientId { set; get; }
        public virtual Patient Patient { set; get; }
        public string PayProcess { set; get; }
        public DateTime CreatedDate { set; get; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal ConsultationFee { set; get; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal PPDFee { set; get; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal FollowUpFee { set; get; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal EarPiercingFee { set; get; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal NebulizationFee { set; get; }
        public string VaccineInfo { set; get; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPayment { set; get; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Balance { set; get; }
        public int BillStatusId { set; get; }   
        public virtual BillStatus BillStatus { set; get; }
    }
}
