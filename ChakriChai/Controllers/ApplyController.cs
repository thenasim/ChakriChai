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
    public class ApplyController : ApiController
    {
        [Route("api/Apply/GetAll/{limit?}")]
        public IHttpActionResult GetAllApplies(int limit = 10) {
            var applies = ApplyService.GetAllApplies(limit);
            if (applies == null)
            {
                return Ok(new ErrMsg("No applies found"));
            }

            return Ok(applies);
        }

        [Route("api/Apply/GetAllByUser/{userId}/{limit?}")]
        public IHttpActionResult GetAllAppliesByUser(int userId, int limit = 10) {
            var applies = ApplyService.GetAllAppliesByUser(userId, limit);
            if (applies == null)
            {
                return Ok(new ErrMsg("No applies found"));
            }

            return Ok(applies);
        }

        [Route("api/Apply/GetAllByJobPost/{jobPostId}/{limit?}")]
        public IHttpActionResult GetAllAppliesByJobPost(int jobPostId, int limit = 10) {
            var applies = ApplyService.GetAllAppliesByJobPost(jobPostId, limit);
            if (applies == null)
            {
                return Ok(new ErrMsg("No applies found"));
            }

            return Ok(applies);
        }

        [Route("api/Apply/Get/{id}")]
        public IHttpActionResult GetAllApply(int id) {
            var apply = ApplyService.GetApply(id);
            if (apply == null)
            {
                return Ok(new ErrMsg("No apply found"));
            }

            return Ok(apply);
        }

        [HttpPost()]
        [Route("api/Apply/Create/{userId}/{jobPostId}")]
        public IHttpActionResult CreateApply(int userId, int jobPostId, ApplyModel ap) {
            var isCreated = ApplyService.CreateApply(userId, jobPostId, ap);
            if (isCreated == false)
            {
                return Ok(new ErrMsg("UserId, JobPostId is invalid"));
            }

            return Ok(new OkMsg("Apply created successfully"));
        }

        [HttpPost()]
        [Route("api/Apply/Update/{applyId}")]
        public IHttpActionResult UpdateApply(int applyId, ApplyModel ap) {
            var isUpdated = ApplyService.UpdateApply(applyId, ap);
            if (isUpdated == false)
            {
                return Ok(new ErrMsg("ApplyId is invalid"));
            }

            return Ok(new OkMsg("Apply updated successfully"));
        }

        [HttpGet()]
        [Route("api/Apply/Delete/{applyId}")]
        public IHttpActionResult Delete(int applyId) {
            var isUpdated = ApplyService.DeleteApply(applyId);
            if (isUpdated == false)
            {
                return Ok(new ErrMsg("ApplyId is invalid"));
            }

            return Ok(new OkMsg("Apply deleted successfully"));
        }
    }
}
