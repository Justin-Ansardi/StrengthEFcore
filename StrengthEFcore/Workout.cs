using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StrengthEFcore
{
    public class Workout
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
        public required User User { get; set; }
        public ICollection<ExerciseBout>? ExerciseBouts { get; set; }
    }
}
