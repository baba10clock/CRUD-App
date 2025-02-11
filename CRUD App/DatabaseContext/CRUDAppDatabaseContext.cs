using Microsoft.EntityFrameworkCore;

namespace CRUDApp.DatabaseContext
{
    public class CRUDAppDatabaseContext : DbContext
    {
        public CRUDAppDatabaseContext(DbContextOptions<CRUDAppDatabaseContext> options)
            : base(options) { }
    }
}
