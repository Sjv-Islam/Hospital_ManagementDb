using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_ManagementDb.Models
{
    public class Staff
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Staff_ID { get; set; }
        [Required]
        [StringLength(50,MinimumLength =4)]
        public string Name { get; set; }
        public string Position { get; set; }
        public virtual Department Department { get; set; } = new Department();
        public int Contact_Info { get; set; }

    }
}
