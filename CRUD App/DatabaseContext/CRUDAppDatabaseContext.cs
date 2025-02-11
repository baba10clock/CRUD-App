using Microsoft.EntityFrameworkCore;

namespace CRUD_App.DatabaseContext
{
    public class CRUDAppDatabaseContext : DbContext
    {
        public CRUDAppDatabaseContext(DbContextOptions<CRUDAppDatabaseContext> options)
            : base(options) { }
    }
}
