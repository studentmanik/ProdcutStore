using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Model
{
    public class Product
    {

        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public int Quantity { get; set; }
      
        
    }
}
