using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class Order
    {

        public string OrderID { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string CustomerID { get; set; }
        [Required]
        public string ProductID { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public ICollection<Customer> Customers { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
