using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrengthEFcore.SeedData
{
    public enum ExerciseSelection
    {
        Squat,
        Deadlift,
        BenchPress,
        OverHeadPress,
        Powerclean
    }
    public static class SeedDataGenerator
    {
        //Initial
        private static Random random = new Random();

        private static string[] firstNames = new string[]
        {
        "John", "Jane", "Alex", "Alice", "Bob",
        "Fiona", "Diana", "George", "Hannah", "Ian",
        "Michael", "Sarah", "David", "Emma", "Chris",
        "Jessica", "Daniel", "Sophia", "Matthew", "Olivia",
        };

        private static string[] lastNames = new string[]
        {
        "Smith", "Johnson", "Williams", "Brown", "Jones",
        "Garcia", "Miller", "Davis", "Rodriguez", "Martinez",
        "Hernandez", "Lopez", "Gonzalez", "Wilson", "Anderson",
        "Thomas", "Taylor", "Moore", "Jackson", "Martin",
        };

        //Generators
        public static List<User> GenerateUsers(int count)
        {

            var ids = Enumerable.Range(1, count).Select(x => x);
            var generatedNames = new HashSet<string>();
            var users = new List<User>();

            int index = 0;
            while (index < count)
            {
                // Generate unique name
                string firstName = firstNames[random.Next(firstNames.Length)];
                string lastName = lastNames[random.Next(lastNames.Length)];
                string fullName = $"{firstName} {lastName}";

                if (!generatedNames.Contains(fullName))
                {
                    generatedNames.Add(fullName);
                }

                index++;
            }

            users = ids.Zip(generatedNames, (first, second) => new User() { Id = first, Name = second }).ToList();
            return users;
        }

        public static List<Workout> GenerateWorkouts(List<User> users)
        {
            var ids = Enumerable.Range(1, users.ToArray().Length).Select(x => x);
            var result = new List<Workout>();
            // ---- Think about creting random datetime generator

            return ids.Zip(users, (x, y) =>
                new Workout()
                {
                    Id = x,
                    UserId = y.Id,
                    DateTime = DateTime.Now,
                    Name = $"{y.Name}'s {DateTime.Now.Day} session", 
                    ExerciseBouts = new List<ExerciseBout>()
                })
             .ToList();
        }


        //public static List<ExerciseBout> GenerateExerciseBouts(List<Workout> workouts)
        //{
        //    var result = new List<ExerciseBout>();

        //    foreach (var workout in workouts)
        //    {
        //        for (int i = 0; i < random.Next(1, 4); i++) // Generate 1 to 3 bouts for each workout
        //        {
        //            result.Add(new ExerciseBout
        //            {
        //                //WorkoutId = workout.Id,
        //                Workout = workout,
        //                Exercise = GetRandomExercise(),
        //                SetReps = GenerateRandomSetsNReps()
        //            });
        //        }
        //    }

        //    return result;
        //}



        public static List<ExerciseBout> GenerateExerciseBouts(List<Workout> workouts)
        {

            var ids = Enumerable.Range(1, workouts.ToArray().Length).Select(x => x);
            var result = new List<ExerciseBout>();

            return ids.Zip(workouts, (x, y) =>
              new ExerciseBout()
              {
                  Id = x,
                  Exercise = GetRandomExercise(),
                  SetReps = GenerateRandomSetsNReps(),
                  WorkoutId = y.Id
              })
             .ToList();
        }




        //Helpers
        public static string GetRandomExercise() =>
            Enum.GetValues<ExerciseSelection>()[random.Next(0, Enum.GetValues<ExerciseSelection>().Length)].ToString();


        public static List<int> GenerateRandomSetsNReps()
        {
            var result = new List<int>();
            var numberOfSets = random.Next(0, 5);

            for (int i = 0; i < numberOfSets; i++)
            {
                result.Add(random.Next(0, 5));
            }

            return result;
        }
    }
}



