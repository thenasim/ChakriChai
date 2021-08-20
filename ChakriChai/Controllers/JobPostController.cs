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
        [Route("api/JobPost/GetAll/{sort}/{limit?}")]
        public IHttpActionResult GetAllJobPosts(string sort, int limit = 10) {
            var jobPosts = JobPostService.GetJobPosts(sort, limit);
            if (jobPosts == null)
            {
                return Ok(new ErrMsg("Invalid userId"));
            }

            return Ok(jobPosts);
        }

        [Route("api/JobPost/GetByUser/{userId}/{limit?}")]
        public IHttpActionResult GetJobPostsByUser(int userId, int limit = 10) {
            var jobPosts = JobPostService.GetJobPostsByUser(userId, limit);
            if (jobPosts == null)
            {
                return Ok(new ErrMsg("Invalid userId"));
            }

            return Ok(jobPosts);
        }

        [Route("api/JobPost/Get/{jobPostId}")]
        public IHttpActionResult Get(int jobPostId)
        {
            var jobPost = JobPostService.GetJobPost(jobPostId);
            if (jobPost == null)
            {
                return Ok(new ErrMsg("No job post found"));
            }

            return Ok(jobPost);
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
