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

        public static List<JobPost> GetJobPostsByUser(int userId, int limit)
        {
            var data = context.Employeers.Where(e => e.UserId == userId).FirstOrDefault();
            if (data == null)
            {
                return null;
            }

            return context.JobPosts.Where(j => j.EmployeerId == data.EmployeerId).Take(limit).ToList();
        }

        public static List<JobPost> GetJobPostsByEmployeer(int employeerId, int limit)
        {
            var data = context.Employeers.Where(e => e.EmployeerId == employeerId).FirstOrDefault();
            if (data == null)
            {
                return null;
            }

            return context.JobPosts.Where(j => j.EmployeerId == employeerId).Take(limit).ToList();
        }

        public static JobPost GetJobPost(int id)
        {
            return context.JobPosts.Find(id);
        }

        public static bool CreateJobPostByUser(int userId, JobPost jb)
        {
            var data = context.Employeers.Where(e => e.UserId == userId).FirstOrDefault();
            if (data == null)
            {
                return false;
            }

            jb.EmployeerId = data.EmployeerId;

            context.JobPosts.Add(jb);
            context.SaveChanges();

            return true;
        }

        public static bool CreateJobPostByEmployeer(int employeerId, JobPost jb)
        {
            var data = context.Employeers.Where(e => e.EmployeerId == employeerId).FirstOrDefault();
            if (data == null)
            {
                return false;
            }

            jb.EmployeerId = data.EmployeerId;

            context.JobPosts.Add(jb);
            context.SaveChanges();

            return true;
        }

        // TODO: Update JobPost

        public static bool DeleteJobPost(int id)
        {
            var job = context.JobPosts.Find(id);
            if (job == null)
            {
                return false;
            }

            context.JobPosts.Remove(job);
            context.SaveChanges();

            return true;
        }
    }
}
