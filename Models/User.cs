using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LEARN_EFCORE.Models
{
    public class User
    {
        public Guid Id{get; set;}
        public required string Name { get; set; }
        public string? Address {get; set;}
        public int Age { get; set; }
        public IEnumerable<Order>? UserOrder {get; set;}
        public IEnumerable<Product>? UserProduct{get; set;}
    }
}