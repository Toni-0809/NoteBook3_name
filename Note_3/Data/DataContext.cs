using Microsoft.EntityFrameworkCore;

namespace Note_3.Data
{

    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Entities.Notes> Notes { get; set; }
        public DbSet<Entities.Users> Users { get; set; }

    }
}