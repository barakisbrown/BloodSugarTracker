using Microsoft.EntityFrameworkCore;

namespace BST_Data
{
    /// <summary>
    /// Exetnsion class to seed some test data so that I can live data
    /// </summary>
    public static class ModelBuilderExtension
    {        
        public static void Seed(this ModelBuilder modelBuilder)
        {
            DateOnly.TryParse("2023/3/20",out DateOnly reading1);
            DateOnly.TryParse("2023/3/20", out DateOnly reading2);
            DateOnly.TryParse("2023/3/10", out DateOnly reading3);
            DateOnly.TryParse("2023/3/01", out DateOnly reading4);
            TimeOnly.TryParse("12:00", out TimeOnly time);

            modelBuilder.Entity<BloodSugar>().HasData(
                new BloodSugar { ID = 1, Amount = 114, DateMessured = reading1, Notes = "Test Notes 1" },
                new BloodSugar { ID = 2, Amount = 164, TimeMessured = time, DateMessured = reading2 },
                new BloodSugar { ID = 3, Amount = 154, DateMessured = reading3 },
                new BloodSugar { ID = 4, Amount = 132, DateMessured = reading4 }
            );
        }
    }
}
