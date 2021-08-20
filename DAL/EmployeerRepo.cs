using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class EmployeerRepo
    {
        private static readonly ChakriChaiContext context;

        static EmployeerRepo()
        {
            context = new ChakriChaiContext();
        }

        public static List<User> GetAllEmployeers(int limit)
        {
            return context.Users.Where(u => u.Role == "EMPLOYEER").Take(limit).ToList();
        }

        public static User GetEmployeer(int userId)
        {
            return context.Users.Where(e => e.UserId == userId && e.Role == "EMPLOYEER").FirstOrDefault();
        }

        public static void CreateEmployeer(Employeer e)
        {
            context.Employeers.Add(e);
            context.SaveChanges();
        }

        // TODO: Update Employeer

        public static void DeleteEmployeer(int userId)
        {
            var emp = context.Users.Where(e => e.UserId == userId && e.Role == "EMPLOYEER").FirstOrDefault();
            context.Users.Remove(emp);
            context.SaveChanges();
        }
    }
}