using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace StrengthEFcore
{
    public class Exercise
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public ExerciseType? ExerciseType { get; set; } // I may need to add and Id prop for these FKs,
                                                                // but I kind of want to see what happens here without them.
    }
}
