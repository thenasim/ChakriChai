using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmployeerRepo
    {
        private static readonly ChakriChaiContext context;

        static EmployeerRepo()
        {
            context = new ChakriChaiContext();
        }

        public static List<Employeer> GetAllEmployeers(int limit)
        {
            return context.Employeers.Take(limit).ToList();
        }

        public static Employeer GetEmployeer(int userId)
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
            var emp = context.Employeers.Where(e => e.UserId == userId).FirstOrDefault();
            context.Employeers.Remove(emp);
            context.SaveChanges();
        }
    }
}
