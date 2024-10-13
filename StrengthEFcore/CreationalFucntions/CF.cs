using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrengthEFcore.CreationalFucntions
{
    public static class CF
    {
        public static async Task CreateNewUser(EntityContext db, User user)
        {
            await db.Users.AddAsync(user);
            await db.SaveChangesAsync();
        }
          
      
    }
}
