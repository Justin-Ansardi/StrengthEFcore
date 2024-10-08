using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StrengthEFcore
{
    public class ExerciseBout
    {
        public required string Id { get; set; }
        public required Workout Workout { get; set; } // Like in other comments, these may have to be set to nullable
                                                      // and have a required FK id prop instead
        public required Exercise Exercise { get; set; }
        public string? SetRepJson { get; set; }

        //public IDictionary<int,int>? SetReps { get; set; } // We will need to convert to a dictionary,
        //                                                    // or other data mapping
        //                                                    // when we interrface with the db
        // 

    }
}
