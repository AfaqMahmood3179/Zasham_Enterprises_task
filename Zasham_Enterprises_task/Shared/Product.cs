using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zasham_Enterprises_task.Shared
{
    public class Product
    {
        public string Product_name { get; set; }
        public string Product_description { get; set; }
        public float Product_price { get; set; }
        
        [Key]
        public String product_id { get; set; }
    
    }
}
