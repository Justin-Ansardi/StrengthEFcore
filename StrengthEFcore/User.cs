

namespace StrengthEFcore
{
    public class User
    {
        public int Id { get; set; } 
        public required string Name { get; set; }
        public ICollection<Workout>? Workouts { get; set; }

    }
}
