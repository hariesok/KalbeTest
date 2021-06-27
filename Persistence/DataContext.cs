using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<PurchaseList> PurchaseList { get; set; }
        public DbSet<PurchaseOrder> PurhaseOrders { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
    }
}