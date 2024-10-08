using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using StrengthEFcore;

namespace StrengthEFcore
{
    internal class EntityContext : DbContext
    {


        public DbSet<User> Users  { get; set; }
        public DbSet<Workout> Workout { get; set; }
        public DbSet<ExerciseBout> ExerciseBout { get; set; }
        public DbSet<Exercise> Exercise { get; set; }
        public DbSet<ExerciseType> ExerciseType { get; set; }

        public string DbPath => "";


        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer($"Data Source={DbPath}");

    }

}
