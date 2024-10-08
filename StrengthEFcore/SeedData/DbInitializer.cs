using Microsoft.EntityFrameworkCore;
using StrengthEFcore;
using StrengthEFcore.SeedData;
using System.Collections.Generic;
using static StrengthEFcore.SeedData.SeedDataGenerator;

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

        modelBuilder.Entity<Workout>().HasData(
         GenerateWorkouts(IList <Users>))
        );

    }

}


