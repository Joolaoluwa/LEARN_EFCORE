using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LEARN_EFCORE.Models
{
    public class Order
    {
        public Guid Id{get; set;}
        public DateTime OrderSent{get; set;}
        public DateTime OrderFulfilled{get; set;}
        public Guid UserId{get; set;}
        public User User{get; set;} = null!;
        public IEnumerable<OrderDetail>? OrderDetail{get; set;}
    }
}