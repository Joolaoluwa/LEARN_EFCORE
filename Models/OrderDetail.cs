using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LEARN_EFCORE.Models
{
    public class OrderDetail
    {
        public Guid Id{get; set;}
        public int Quantity{get; set;}
        public Guid ProductId{get; set;}
        public Guid OrderId{get; set;}
        public Product? Product{get; set;}
        public Order? Order{get; set;}
    }
}