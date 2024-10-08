using System.ComponentModel.DataAnnotations;

namespace StrengthEFcore
{
    public class ExerciseType
    {
        public required string Id { get; set; }
        public required string Name { get; set; }
    }
}
