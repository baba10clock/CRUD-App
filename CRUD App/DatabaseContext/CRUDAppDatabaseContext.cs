using CRUDApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDApp.DatabaseContext
{
    public class CRUDAppDatabaseContext : DbContext
    {
        public CRUDAppDatabaseContext(DbContextOptions<CRUDAppDatabaseContext> options)
            : base(options) { }

        public DbSet<Product> Products => Set<Product>();
    }
}
