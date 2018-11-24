using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SaintJudeHospital.Data.Entity
{
    public class Bill
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        public int CheckupId { set; get; }
        public virtual Checkup Checkup {set; get;}
        public int PatientId { set; get; }
        public virtual Patient Patient { set; get; }
        public string PayProcess { set; get; }
        public DateTime CreatedDate { set; get; }
        public decimal ConsultationFee { set; get; }
        public decimal PPDFee { set; get; }
        public decimal FollowUpFee { set; get; }
        public decimal EarPiercingFee { set; get; }
        public decimal NebulizationFee { set; get; }
        public string VaccineInfo { set; get; }
        public decimal TotalPayment { set; get; }
        public decimal Balance { set; get; }
        public int BillStatusId { set; get; }   
        public virtual BillStatus BillStatus { set; get; }
    }
}
