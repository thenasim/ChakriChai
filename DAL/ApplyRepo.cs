using System.Collections.Generic;
using System.Linq;

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

        public static List<Apply> GetAppliesByUser(int userId, int limit)
        {
            var data = context.Employees.Where(e => e.UserId == userId).FirstOrDefault();
            if (data == null)
            {
                return null;
            }

            return context.Applies.Where(a => a.EmployeeId == data.EmployeeId).Take(limit).ToList();
        }

        public static List<Apply> GetAppliesByJobPost(int jobPostId, int limit)
        {
            return context.Applies.Where(a => a.JobPostId == jobPostId).Take(limit).ToList();
        }

        public static Apply GetApply(int id)
        {
            return context.Applies.Find(id);
        }

        public static bool CreateApply(int userId, int jobPostId, Apply ap)
        {
            var data = context.Employees.Where(e => e.UserId == userId).FirstOrDefault();
            if (data == null)
            {
                return false;
            }

            ap.EmployeeId = data.EmployeeId;
            ap.JobPostId = jobPostId;

            context.Applies.Add(ap);
            context.SaveChanges();

            return true;
        }

        public static bool UpdateApply(int applyId, Apply ap)
        {
            var apply = context.Applies.Find(applyId);
            if (apply == null)
            {
                return false;
            }

            ap.ApplyId = apply.ApplyId;
            ap.EmployeeId = apply.EmployeeId;
            ap.JobPostId = apply.JobPostId;

            context.Entry(apply).CurrentValues.SetValues(ap);
            context.SaveChanges();

            return true;
        }

        public static bool DeleteApply(int id)
        {
            var apply = context.Applies.Find(id);
            if (apply == null)
            {
                return false;
            }

            context.Applies.Remove(apply);
            context.SaveChanges();

            return true;
        }
    }
}