using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LEARN_EFCORE.Models
{
    public class Product
    {
        public Guid Id{get; set;}
        public string? ProductName{get; set;}
        public string? ProductType{get; set;}
        public string? ProductColor{get; set;}
        public string? Location{get; set;}
        public string? Choices{get; set;}
        public decimal? Price{get; set;}
    }
}