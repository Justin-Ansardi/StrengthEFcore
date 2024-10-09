using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StrengthEFcore
{
    public class ExerciseBout
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public required Workout Workout { get; set; } 
        public string Exercise { get; set; } = "Default";

        public IList<int>? SetReps { get; set; }
}
}
