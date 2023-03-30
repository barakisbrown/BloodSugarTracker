using Microsoft.EntityFrameworkCore;

namespace BST_Data
{
    public class BSTContext : DbContext
    {
        public DbSet<BloodSugar> Readings { get; set; }

        public string DbPath { get; set; }

        public BSTContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "readings.db");
        }

        // CREATES THE SQL DB
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite($"Data Source = {DbPath}");
    }
}