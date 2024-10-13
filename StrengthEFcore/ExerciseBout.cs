using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StrengthEFcore
{
    public class ExerciseBout
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }
        public int? WorkoutId { get; set; }

        [JsonIgnore] // This maybe should go somewhere else.... It works but is out of scope
        public Workout? Workout { get; set; }  
        public string Exercise { get; set; } = "Default";

        public IList<int>? SetReps { get; set; }
}
}
