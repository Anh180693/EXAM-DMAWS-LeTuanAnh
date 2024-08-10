using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Store_Chart.Models
{
    public class Dbcontext : DbContext
    {
        public Dbcontext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<OrderTbl> OrderTbls { get; set; }
    }
}
