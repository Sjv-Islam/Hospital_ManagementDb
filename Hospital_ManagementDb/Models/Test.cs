using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_ManagementDb.Models
{
    public class Test
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Test_ID { get; set; }
        public virtual Patient Patient { get; set; } = new Patient();
        public virtual Doctor Doctor { get; set; } = new Doctor();

        public Test_Type Type_Of_Test { get; set; }

        public string Result { get; set; }
        public DateOnly Date { get; set; }
    }


    public class Test_Type
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
