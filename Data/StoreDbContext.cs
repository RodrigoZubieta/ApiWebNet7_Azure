using Microsoft.EntityFrameworkCore;
using WepApiNet7.Models;

namespace WepApiNet7.Data
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options) { }

        public DbSet<ProductEntity> Products { get; set; }
    }
}
