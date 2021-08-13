using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmployeeRepo
    {
        private static readonly ChakriChaiContext context;

        static EmployeeRepo()
        {
            context = new ChakriChaiContext();
        }

        public static List<User> GetAllEmployees(int limit)
        {
            return context.Users.Where(e => e.Role == "EMPLOYEE").Take(limit).ToList();
        }

        public static User GetEmployee(int userId)
        {
            return context.Users.Where(e => e.UserId == userId && e.Role == "EMPLOYEE").FirstOrDefault();
        }

        public static void CreateEmployee(Employee e)
        {
            context.Employees.Add(e);
            context.SaveChanges();
        }

        // TODO: Update Employee

        public static void DeleteEmployee(int userId)
        {
            var emp = context.Users.Where(e => e.UserId == userId && e.Role == "EMPLOYEE").FirstOrDefault();
            context.Users.Remove(emp);
            context.SaveChanges();
        }
    }
}
