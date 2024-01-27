using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_ManagementDb.Models
{
    public class Appointment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Appointment_ID { get; set; }
        public virtual Patient Patient { get; set; } = new Patient();
        public virtual Doctor Doctor { get; set; } = new Doctor();

        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }

    }
}
