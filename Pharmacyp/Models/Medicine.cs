using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pharmacyp.Models
{
    public class Medicine
    {
        [Key]
        public int MedicineId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string MedicineName { get; set; }

        [Required]
        [Column(TypeName = "varchar(16)")]
        public string Price { get; set; }

        public ICollection<Company> Companies { get; set; }
        
    }
}
