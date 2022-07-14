using CSRegler.Models;
using Microsoft.EntityFrameworkCore;

namespace CSRegler.Data
{
    public class BilderDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite(@"Data Source=FileUpload.db");
        public DbSet<UplodedFileModel> uplodedFileModels { get; set; }

    }
}
