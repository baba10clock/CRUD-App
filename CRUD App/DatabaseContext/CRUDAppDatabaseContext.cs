using Microsoft.EntityFrameworkCore;

namespace CRUD_App.DatabaseContext
{
    public class CRUDAppDatabaseContext : DbContext
    {
        public IConfiguration _config;

        public CRUDAppDatabaseContext(IConfiguration config)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("CRUDAppDatabase");
        }
    }
}
