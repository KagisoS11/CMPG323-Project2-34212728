using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EcoPowerLogistics_Project2_API.Controllers.Models;

namespace EcoPowerLogistics_Project2_API.Data
{
    public class EcoPowerLogistics_Project2_APIContext : DbContext
    {
        public EcoPowerLogistics_Project2_APIContext (DbContextOptions<EcoPowerLogistics_Project2_APIContext> options)
            : base(options)
        {
        }

        public DbSet<EcoPowerLogistics_Project2_API.Controllers.Models.Products> Products { get; set; } = default!;

        public DbSet<EcoPowerLogistics_Project2_API.Controllers.Models.Orders>? Orders { get; set; }

        public DbSet<EcoPowerLogistics_Project2_API.Controllers.Models.OrderDetails>? OrderDetails { get; set; }

        public DbSet<EcoPowerLogistics_Project2_API.Controllers.Models.Customers>? Customers { get; set; }
    }
}
