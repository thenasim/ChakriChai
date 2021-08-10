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

        public static List<Employee> GetAllEmployees(int limit)
        {
            return context.Employees.Take(limit).ToList();
        }

        public static Employee GetEmployee(int userId)
        {
            return context.Employees.Where(e => e.UserId == userId).FirstOrDefault();
        }

        public static void CreateEmployee(Employee e)
        {
            context.Employees.Add(e);
            context.SaveChanges();
        }

        // TODO: Update Employee

        public static void DeleteEmployee(int userId)
        {
            var emp = context.Employees.Where(e => e.UserId == userId).FirstOrDefault();
            context.Employees.Remove(emp);
            context.SaveChanges();
        }
    }
}
