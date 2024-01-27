using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_ManagementDb.Models
{
    public class Doctor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Doctor_ID { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public string Specialization { get; set; }
        public int Contact_Info { get; set; }
    }
}
