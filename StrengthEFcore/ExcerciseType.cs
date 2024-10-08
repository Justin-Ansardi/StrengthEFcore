using System.ComponentModel.DataAnnotations;

namespace StrengthEFcore
{
    public class ExerciseType
    {
        public int Id { get; set; }
        public required string Name { get; set; }
    }
}
