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
         users.Select(x => new Workout() { User = x, DateTime = DateTime.Now }).ToList();

        public static List<ExerciseBout> GenerateExerciseBout(List<Workout> workouts) =>
            workouts.Select(x =>
                                 new ExerciseBout()
                                 {
                                     Exercise = GetRandomExercise(),
                                     SetReps = GenerateRandomSetsNReps(),
                                     Workout = x
                                 })
            .ToList();

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
   



        //public static List<int> GenerateRandomSetsNReps()
        //    => new List<int>() { (random.Next(0, 6)), (random.Next(0, 6)) }; 

        // we may need a matrix 
        /* ex1:
         * 1 - 5
         * 2 - 5
         * 3 - 4
         * 
         * ex2:
         * 1 - 5
         * 2 - 5
         * 3 - 5
         * 4 - 5
         * */



    }



}



