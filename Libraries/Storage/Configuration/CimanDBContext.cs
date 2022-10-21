using Entities.Areas;
using Entities.Companies;
using Microsoft.EntityFrameworkCore;

namespace Storage.Configuration
{
    public class CimanDBContext : DbContext
    {
        public CimanDBContext(DbContextOptions<CimanDBContext> opt) : base(opt)
        {
            
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Area> Areas { get; set; }
    }
}
