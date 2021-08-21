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
    public class ExamController : ApiController
    {
        [Route("api/Exam/GetAll")]
        public List<ExamModel> GetAllExams() {
            return ExamService.GetAllExams();
        }


        [Route("api/Exam/Get/{id}")]
        public ExamModel Get(int id) {
            return ExamService.GetExam(id);
        }

        [HttpPost()]
        [Route("api/Exam/Create")]
        public void CreateExam(ExamModel e)
        {
            ExamService.CreateExam(e);
        }

        [HttpGet()]
        [Route("api/Exam/Delete/{id}")]
        public void Delete(int id)
        {
            ExamService.DeleteExam(id);
        }
    }
}
