using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_ManagementDb.Models
{
    public class Billing
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Bill_ID { get; set; }
        public virtual Patient Patient { get; set; } = new Patient();
        public decimal Total_Amount { get; set; }
        public bool Payment_Status { get; set; }
        public DateAndTime Billing_Date { get; set; }
    }
}
