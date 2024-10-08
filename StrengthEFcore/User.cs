using System.ComponentModel.DataAnnotations;

namespace StrengthEFcore
{
    public class User
    {
        public required string Id { get; set; } 
        public required string Name { get; set; }
        public ICollection<Workout>? Workouts { get; set; }

    }
}
