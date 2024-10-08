using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StrengthEFcore
{
    public class ExerciseBout
    {
        public int Id { get; set; }
        public required Workout Workout { get; set; } // Like in other comments, these may have to be set to nullable
                                                      // and have a required FK id prop instead
        public required string Exercise { get; set; } 

        public IList<int>? SetReps { get; set; }
}
}
