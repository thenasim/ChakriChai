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

        public static List<Academic> GetAcademicsByUser(int userId, int limit)
        {
            var data = context.Employees.Where(e => e.UserId == userId).FirstOrDefault();
            if (data == null)
            {
                return null;
            }

            return context.Academics.Where(a => a.EmployeeId == data.EmployeeId).Take(limit).ToList();
        }

        public static Academic GetAcademic(int id)
        {
            return context.Academics.Where(e => e.AcademicId == id).FirstOrDefault();
        }

        public static bool CreateAcademic(int userId, Academic a)
        {
            var data = context.Employees.Where(e => e.UserId == userId).FirstOrDefault();
            if (data == null)
            {
                return false;
            }

            a.EmployeeId = data.EmployeeId;

            context.Academics.Add(a);
            context.SaveChanges();

            return true;
        }

        public static bool UpdateAcademic(int academicId, Academic a)
        {
            var academic = context.Academics.Find(academicId);
            if (academic == null)
            {
                return false;
            }

            a.AcademicId = academic.AcademicId;
            a.EmployeeId = academic.EmployeeId;
            a.ExamId = academic.ExamId;
            a.BoardId = academic.BoardId;

            context.Entry(academic).CurrentValues.SetValues(a);
            context.SaveChanges();

            return true;
        }

        public static bool DeleteAcademic(int id)
        {
            var academic = context.Academics.Find(id);
            if (academic == null)
            {
                return false;
            }

            context.Academics.Remove(academic);
            context.SaveChanges();

            return true;
        }
    }
}
