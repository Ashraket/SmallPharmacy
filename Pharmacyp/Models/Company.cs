using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pharmacyp.Models
{
    public class Company
    {
        [Key]
        
        public int CompanyId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string CompanyName { get; set; }

        
        [Column(TypeName = "varchar(16)")]
        public string CompanyNumber { get; set; }

        
        public int MedicineId { get; set; }
        public Medicine Medicine { get; set; }

    }
}
