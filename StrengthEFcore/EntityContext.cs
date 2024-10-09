using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Security.Cryptography;
using System.Text.Json;
using static System.Text.Json.JsonSerializer;


namespace StrengthEFcore
{
    public class EntityContext : DbContext
    {


        public DbSet<User> Users  { get; set; }
        public DbSet<Workout> Workout { get; set; }
        public DbSet<ExerciseBout> ExerciseBout { get; set; }
        public DbSet<Exercise> Exercise { get; set; }
        public DbSet<ExerciseType> ExerciseType { get; set; }

        public static string DbPath => "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Strength;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public EntityContext(DbContextOptions<EntityContext> options): base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.EnableSensitiveDataLogging(); // this should be checked for (isDevMode) in the middleware pipeline 
            options.UseSqlServer(DbPath);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
          

            new DbInitializer(modelBuilder).Seed();

        }
    }

    public class ExerciseBoutsConfiguration : IEntityTypeConfiguration<ExerciseBout>
    {
        public void Configure(EntityTypeBuilder<ExerciseBout> builder)
        {
            builder.Property(e => e.SetReps).HasConversion(
                v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                v => JsonConvert.DeserializeObject<IList<int>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));
        }
    }

}
