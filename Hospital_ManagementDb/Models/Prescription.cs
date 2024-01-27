using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_ManagementDb.Models
{
    public class Prescription
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Prescription_ID { get; set; }
        public virtual Patient Patient { get; set; } = new Patient();
        public virtual Doctor Doctor { get; set; } = new Doctor();

        public string Medication { get; set; }
        public decimal Dosage { get; set; }
        public DateOnly Date_Issued { get; set; }
    }
}
