using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zasham_Enterprises_task.Shared
{
    public class Customer
    {
        public String Customer_name { get; set; }
        public String Customer_email { get; set; }
        [Key]
        public String Customer_phone { get; set; }
        public String Customer_address { get; set; }
    }
}
