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

        [HttpPost()]
        [Route("api/Employeer/Create")]
        public void CreateEmployeer(UserModel u)
        {
            u.Role = "EMPLOYEER";
            u.Status = "INACTIVE";
            UserService.CreateUser(u);
        }

        // TODO: Update User Route

        [Route("api/Employeer/Delete/{userId}")]
        public void DeleteEmployeer(int userId)
        {
            EmployeerService.DeleteEmployeer(userId);
        }
    }
}
