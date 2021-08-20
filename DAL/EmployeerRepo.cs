using System;
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

        public static bool UpdateEmployeerDetails(int userId, Employeer emp)
        {
            var data = context.Employeers.Where(e => e.UserId == userId).FirstOrDefault();
            if (data == null)
            {
                return false;
            }

            emp.EmployeerId = data.EmployeerId;
            emp.UserId = data.UserId;

            context.Entry(data).CurrentValues.SetValues(emp);
            context.SaveChanges();

            return true;
        }

        public static Employeer GetEmployeerDetails(int userId)
        {
            return context.Employeers.Where(e => e.UserId == userId).FirstOrDefault();
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