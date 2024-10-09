using Microsoft.EntityFrameworkCore;
using StrengthEFcore;
using StrengthEFcore.SeedData;
using System.Collections.Generic;
using System.Reflection.Emit;
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
        var users = GenerateUsers(100);
        var workouts = GenerateWorkouts(users);
        //var bout = GenerateExerciseBout(workouts);

         modelBuilder.Entity<User>().HasData(users);
         modelBuilder.Entity<Workout>().HasData(workouts);
         //modelBuilder.Entity<ExerciseBout>().HasData(bout);
    }

}


