using Microsoft.EntityFrameworkCore;
using StrengthEFcore;
using StrengthEFcore.SeedData;
using static StrengthEFcore.SeedData.UserGenerator;

public class DbInitializer
{
    private readonly ModelBuilder modelBuilder;

    public DbInitializer(ModelBuilder modelBuilder)
    {
        this.modelBuilder = modelBuilder;
    }

    public void Seed()
    {
        modelBuilder.Entity<User>().HasData(
         GenerateUsers(100)
        );
    }
}


