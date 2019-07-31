using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaintJudeHospital.Data.Entity
{
    public class Role
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int RoleId { set; get; }
        public string Name { set; get; }
    }
}
