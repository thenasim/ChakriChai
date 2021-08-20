using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChakriChai.Controllers
{
    public class JobPostController : ApiController
    {
        [Route("api/JobPost/GetByUser/{userId}/{limit?}")]
        public IHttpActionResult GetJobPostsByUser(int userId, int limit = 10) {
            var jobPosts = JobPostService.GetJobPostsByUser(userId, limit);
            if (jobPosts == null)
            {
                return Ok(new ErrMsg("Invalid userId"));
            }

            return Ok(jobPosts);
        }

        //[Route("api/JobPost/GetByEmployeer/{employeerId}/{limit?}")]
        //public IHttpActionResult GetJobPostsByEmployeer(int employeerId, int limit = 10) {
        //    var jobPosts = JobPostService.GetJobPostsByEmployeer(employeerId, limit);
        //    if (jobPosts == null)
        //    {
        //        return Ok(new { msg = "No Job posts found for this employeeId" });
        //    }

        //    return Ok(jobPosts);
        //}

        [Route("api/JobPost/Get/{jobPostId}")]
        public JobPostModel Get(int jobPostId) {
            return JobPostService.GetJobPost(jobPostId);
        }

        [HttpPost()]
        [Route("api/JobPost/CreateByUser/{userId}")]
        public IHttpActionResult CreateJobPostByUser(int userId, JobPostModel jb)
        {
            if (JobPostService.CreateGetJobPost(userId, jb))
            {
                return Ok(new OkMsg("Created successfully"));
            }

            return Ok(new ErrMsg("User id not found"));
        }

        [Route("api/JobPost/Delete/{jobPostId}")]
        public IHttpActionResult Delete(int jobPostId) {
            if (JobPostService.DeleteJobPost(jobPostId))
            {
                return Ok(new OkMsg("Deleted successfully"));
            }

            return Ok(new ErrMsg("Job post not found"));
        }
    }
}
