using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class Cart
    {

        public string CartID { get; set; }
        public string ProductID { get; set; }
        public string CustomerID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;
        public ICollection<Customer> customers { get; set; }
        public ICollection<Product> products { get; set; }

    }
}
