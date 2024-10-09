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

        public static List<Workout> GenerateWorkouts(List<User> users) =>
         users.Select(x => new Workout() { Id = 1, User = x, DateTime = DateTime.Now }).ToList();

        public static List<ExerciseBout> GenerateExerciseBout(List<Workout> workouts) =>
            workouts.Select(x =>
                                 new ExerciseBout()
                                 {
                                     Id = 1,
                                     Exercise = GetRandomExercise(),
                                     SetReps = GenerateRandomSetsNReps(),
                                     Workout = x
                                 })
            .ToList();



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



