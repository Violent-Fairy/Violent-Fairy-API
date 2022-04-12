using Violent.Fairy.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Violent_Fairy.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        { }

        public DbSet<Item> Items { get; set; }
    }
}

