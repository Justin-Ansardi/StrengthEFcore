﻿

using System.ComponentModel.DataAnnotations.Schema;

namespace StrengthEFcore
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } 
        public string? Name { get; set; }
        public ICollection<Workout>? Workouts { get; set; }

    }
}
