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

            using(var context = new BSTContext())
            {
                bool isCreated = context.Database.EnsureCreated();
                if (isCreated)                    
                    Console.WriteLine("Database Created and Seeded.");
                else
                    Console.Error.WriteLine("Database Could not be created");
            }
        }

        // CREATES THE SQL DB
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }

        
    }
}