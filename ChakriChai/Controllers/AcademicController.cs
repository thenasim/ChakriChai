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
    public class AcademicController : ApiController
    {
        [Route("api/Academic/GetAll/{limit?}")]
        public IHttpActionResult GetAllAcademic(int limit = 10) {
            var academics = AcademicService.GetAllApplies(limit);
            if (academics == null)
            {
                return Ok(new ErrMsg("No academics found"));
            }

            return Ok(academics);
        }

        [Route("api/Academic/GetAllByUser/{userId}/{limit?}")]
        public IHttpActionResult GetAllByUser(int userId, int limit = 10) {
            var academics = AcademicService.GetAcademicsByUser(userId, limit);
            if (academics == null)
            {
                return Ok(new ErrMsg("No academics found"));
            }

            return Ok(academics);
        }

        [Route("api/Academic/Get/{academicId}")]
        public IHttpActionResult GetAcademic(int academicId) {
            var academics = AcademicService.GetAcademic(academicId);
            if (academics == null)
            {
                return Ok(new ErrMsg("No academic found"));
            }

            return Ok(academics);
        }

        [HttpPost()]
        [Route("api/Academic/Create/userid/{userId}")]
        public IHttpActionResult CreateAcademics(int userId, AcademicModel ac) {
            var isCreated = AcademicService.CreateAcademic(userId, ac);
            if (isCreated == false)
            {
                return Ok(new ErrMsg("Error creating academic"));
            }

            return Ok(new OkMsg("Successfully created academic"));
        }

        [HttpPost()]
        [Route("api/Academic/Update/{academicId}")]
        public IHttpActionResult UpdateAcademic(int academicId, AcademicModel ac) {
            var isUpdated = AcademicService.UpdateAcademic(academicId, ac);
            if (isUpdated == false)
            {
                return Ok(new ErrMsg("AcademicId is invalid"));
            }

            return Ok(new OkMsg("Academic updated successfully"));
        }

        [Route("api/Academic/Delete/{academicId}")]
        public IHttpActionResult Delete(int academicId) {
            var isDeleted = AcademicService.DeleteAcademic(academicId);
            if (isDeleted == false)
            {
                return Ok(new ErrMsg("No academic found, unable to delet"));
            }

            return Ok(new OkMsg("Academic deleted successfully"));
        }
    }
}
