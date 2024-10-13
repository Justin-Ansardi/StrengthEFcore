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
        public static IQueryable<User> GetAllUsers(EntityContext db)
            => db.Users.Select(x => x);

    }
}
