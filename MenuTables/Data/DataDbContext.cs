using MenuTables.Models;
using Microsoft.EntityFrameworkCore;

namespace MenuTables.Data
{
    public class DataDbContext:DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext>options):base(options) { }

        public DbSet<TblMenu> TblMenus { get; set; }

    }
}
