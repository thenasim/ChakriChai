using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserRepo
    {
        private static readonly ChakriChaiContext context;

        static UserRepo()
        {
            context = new ChakriChaiContext();
        }

        public static List<User> GetAllUsers(int limit)
        {
            return context.Users.Take(limit).ToList();
        }

        public static User GetUser(int id)
        {
            return context.Users.Find(id);
        }

        public static void CreateUser(User u)
        {
            context.Users.Add(u);
            context.SaveChanges();
        }

        public static void DeleteUser(int id)
        {
            User user = context.Users.Find(id);
            context.Users.Remove(user);
            context.SaveChanges();
        }
    }
}
