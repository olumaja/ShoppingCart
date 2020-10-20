using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class Customer : IdentityUser
    {
        [Required]
        [MaxLength(30, ErrorMessage ="Maximum character length allow is 30")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "Maximum character length allow is 30")]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        public string Photo { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public Order Ordered { get; set; }
        public Cart Carts { get; set; }
    }
}
