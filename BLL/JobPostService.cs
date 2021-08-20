using BEL;
using DAL;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class JobPostService
    {
        public static List<JobPostViewModel> GetJobPosts(string sort, int limit)
        {
            var data = JobPostRepo.GetJobPosts(sort, limit);
            var result = AutoMapper.Mapper.Map<List<JobPost>, List<JobPostViewModel>>(data);
            return result;
        }

        public static List<JobPostViewModel> SearchJobPost(string keyword)
        {
            var data = JobPostRepo.SearchJobPost(keyword);
            var result = AutoMapper.Mapper.Map<List<JobPost>, List<JobPostViewModel>>(data);
            return result;
        }

        public static List<JobPostModel> GetJobPostsByUser(int userId, int limit)
        {
            var data = JobPostRepo.GetJobPostsByUser(userId, limit);
            var result = AutoMapper.Mapper.Map<List<JobPost>, List<JobPostModel>>(data);
            return result;
        }

        //public static List<JobPostModel> GetJobPostsByEmployeer(int employeerId, int limit)
        //{
        //    var data = JobPostRepo.GetJobPostsByEmployeer(employeerId, limit);
        //    var result = AutoMapper.Mapper.Map<List<JobPost>, List<JobPostModel>>(data);
        //    return result;
        //}

        public static JobPostModel GetJobPost(int id)
        {
            var data = JobPostRepo.GetJobPost(id);
            var result = AutoMapper.Mapper.Map<JobPost, JobPostModel>(data);
            return result;
        }

        public static bool CreateJobPost(int userId, JobPostModel jb)
        {
            var data = AutoMapper.Mapper.Map<JobPostModel, JobPost>(jb);
            return JobPostRepo.CreateJobPostByUser(userId, data);
        }

        public static bool DeleteJobPost(int jobPostId)
        {
            return JobPostRepo.DeleteJobPost(jobPostId);
        }
    }
}