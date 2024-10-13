using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrengthEFcore.DataAcessFunctions
{
    public static class DAF
    {
        public static IQueryable<Workout> GetUserWorkoutData(EntityContext db, int userId)
            => db.Workout.Select(x => x)
                         .Include(x => x.ExerciseBouts)
                         .Where(x => x.UserId == userId);


        public static IQueryable<User> GetAllUsers(EntityContext db)
            => db.Users.Select(x => x);

        public static IQueryable<Workout> GetWorkout(EntityContext db, int id)
            => db.Workout.Select(x => x).Include(x => x.ExerciseBouts).Where(x => x.Id == id);

        public static IQueryable<ExerciseBout> GetExerciseBouts(EntityContext db, int workoutId)
            => db.ExerciseBout.Select(x => x).Where(x => x.WorkoutId == workoutId);
    }
}
