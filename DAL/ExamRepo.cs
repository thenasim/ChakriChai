using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ExamRepo
    {
        private static readonly ChakriChaiContext context;

        static ExamRepo()
        {
            context = new ChakriChaiContext();
        }

        public static List<Exam> GetAllExams()
        {
            return context.Exams.ToList();
        }

        public static Exam GetExam(int id)
        {
            return context.Exams.Find(id);
        }

        public static void CreateExam(Exam e)
        {
            context.Exams.Add(e);
            context.SaveChanges();
        }

        public static void UpdateExam(Exam e, int id)
        {
            // TODO: Verify this method
            var exam = context.Exams.Find(id);
            exam = e;
            context.SaveChanges();
        }

        public static void DeleteExam(int id)
        {
            var exam = context.Exams.Find(id);
            context.Exams.Remove(exam);
            context.SaveChanges();
        }
    }
}
