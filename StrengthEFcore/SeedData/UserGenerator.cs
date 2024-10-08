using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrengthEFcore.SeedData
{
    // Future version could query existing database entries, if devs ever wanted to generate more data.
    public static class UserGenerator
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

            IEnumerable<int> ids = Enumerable.Range(1, count).Select(x => x);
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

            users = ids.Zip(generatedNames, (first, second) => new User() { Id = first.ToString(), Name = second }).ToList();
            return users;
        }
    }
}
