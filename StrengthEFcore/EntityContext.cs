using Microsoft.EntityFrameworkCore;


namespace StrengthEFcore
{
    internal class EntityContext : DbContext
    {


        public DbSet<User> Users  { get; set; }
        public DbSet<Workout> Workout { get; set; }
        public DbSet<ExerciseBout> ExerciseBout { get; set; }
        public DbSet<Exercise> Exercise { get; set; }
        public DbSet<ExerciseType> ExerciseType { get; set; }

        public string DbPath => "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Strength;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";


        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer($"Data Source={DbPath}");

    }

}
