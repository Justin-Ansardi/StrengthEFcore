using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StrengthEFcore
{
    public class ExerciseBout
    {
        public int Id { get; set; }
        public required Workout Workout { get; set; } // Like in other comments, these may have to be set to nullable
                                                      // and have a required FK id prop instead
        public required Exercise Exercise { get; set; }


        [NotMapped] //temp only, do not leave it this way!!!
        public IDictionary<string,string>? SetReps { get; set; }
}
}
