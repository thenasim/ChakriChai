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
    public class EmployeerController : ApiController
    {
        [Route("api/Employeer/GetAll/{limit?}")]
        public List<UserModel> GetAllEmployee(int limit = 10) {
            return EmployeerService.GetAllEmployeer(limit);
        }

        [Route("api/Employeer/Get/{userId}")]
        public UserModel Get(int userId) {
            return EmployeerService.GetEmployeer(userId);
        }

        [Route("api/Employeer/GetDetails/{userId}")]
        public EmployeerModel GetEmployeerDetails(int userId) {
            return EmployeerService.GetEmployeerDetails(userId);
        }

        [HttpPost()]
        [Route("api/Employeer/Create")]
        public void CreateEmployeer(UserModel u)
        {
            u.Role = "EMPLOYEER";
            u.Status = "INACTIVE";
            UserService.CreateUser(u);
        }

        [HttpPost()]
        [Route("api/Employeer/Update/{userId}")]
        public void Update(int userId, EmployeerModel emp)
        {
            EmployeerService.UpdateEmployeer(userId, emp);
        }

        [HttpGet()]
        [Route("api/Employeer/Delete/{userId}")]
        public void DeleteEmployeer(int userId)
        {
            EmployeerService.DeleteEmployeer(userId);
        }
    }
}
