using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_ManagementDb.Models
{
    public class Admission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Admission_ID { get; set; }
        public virtual Patient Patient { get; set; } = new Patient();
        public virtual Room Room { get; set; } = new Room();
        public DateTime Admission_Date { get; set; }
        public DateTime Discharge_Date { get; set; }
    }
}
