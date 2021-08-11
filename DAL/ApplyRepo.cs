using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ApplyRepo
    {
        private static readonly ChakriChaiContext context;

        static ApplyRepo()
        {
            context = new ChakriChaiContext();
        }

        public static List<Apply> GetAllApplies(int limit)
        {
            return context.Applies.Take(limit).ToList();
        }

        public static List<Apply> GetAppliesByEmployee(int employeeId, int limit)
        {
            return context.Applies.Where(a => a.EmployeeId == employeeId).Take(limit).ToList();
        }

        public static Apply GetApply(int id)
        {
            return context.Applies.Find(id);
        }

        public static void CreateApply(Apply a)
        {
            context.Applies.Add(a);
            context.SaveChanges();
        }

        // TODO: Update Apply

        public static void DeleteApply(int id)
        {
            var apply = context.Applies.Find(id);
            context.Applies.Remove(apply);
            context.SaveChanges();
        }
    }
}
