using Microsoft.EntityFrameworkCore;

namespace EcoPowerLogistics_Project2_API.Controllers.Models
{
    public class DBContext
    {
        public DbSet<Customers> Customers { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Products> Products { get; set; }

    }
}
