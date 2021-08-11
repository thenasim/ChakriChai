using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class JobPostRepo
    {
        private static readonly ChakriChaiContext context;

        static JobPostRepo()
        {
            context = new ChakriChaiContext();
        }

        public static List<JobPost> GetAllJobPosts(int limit)
        {
            return context.JobPosts.Take(limit).ToList();
        }

        public static List<JobPost> GetJobPostsByEmployeer(int employeerId, int limit)
        {
            return context.JobPosts.Where(j => j.EmployeerId == employeerId).Take(limit).ToList();
        }

        public static JobPost GetJobPost(int id)
        {
            return context.JobPosts.Find(id);
        }
        
        public static void CreateJobPost(JobPost j)
        {
            context.JobPosts.Add(j);
            context.SaveChanges();
        }

        // TODO: Update JobPost

        public static void DeleteJobPost(int id)
        {
            var job = context.JobPosts.Find(id);
            context.JobPosts.Remove(job);
            context.SaveChanges();
        }
    }
}
