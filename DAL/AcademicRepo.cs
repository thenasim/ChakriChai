using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AcademicRepo
    {
        private static readonly ChakriChaiContext context;

        static AcademicRepo()
        {
            context = new ChakriChaiContext();
        }
        
        public static List<Academic> GetAllAcademics(int limit)
        {
            return context.Academics.Take(limit).ToList();
        }

        public static List<Academic> GetAcademicsByEmployee(int employeeId, int limit)
        {
            return context.Academics.Where(a => a.EmployeeId == employeeId).Take(limit).ToList();
        }

        public static void CreateAcademic(Academic a)
        {
            context.Academics.Add(a);
            context.SaveChanges();
        }

        // TODO: Update Academic

        public static void DeleteAcademic(int id)
        {
            var academic = context.Academics.Find(id);
            context.Academics.Remove(academic);
            context.SaveChanges();
        }
    }
}
