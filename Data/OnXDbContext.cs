using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LEARN_EFCORE.Models;
using System.Data.Common;

namespace LEARN_EFCORE.Data;
public class OnXDbContext : DbContext
{
        private readonly string dbConnectionStringBuilder = "server=localhost;database=OnXDb;User=root;Password=Jolaoluwa2002@";
        public DbSet<User> User {get; set;} = null!;
        public DbSet<Order> Order {get; set;} = null!;
        public DbSet<OrderDetail> OrderDetail {get; set;} = null!;
        public DbSet<Product> Product {get; set;} = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(dbConnectionStringBuilder,ServerVersion.AutoDetect(dbConnectionStringBuilder));
        }
}