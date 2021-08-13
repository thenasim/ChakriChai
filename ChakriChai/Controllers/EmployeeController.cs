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
    public class EmployeeController : ApiController
    {
        [Route("api/Employee/GetAll/{limit?}")]
        public List<UserModel> GetAllEmployee(int limit = 10) {
            return EmployeeService.GetAllEmployee(limit);
        }

        [Route("api/Employee/Get/{userId}")]
        public UserModel Get(int userId) {
            return EmployeeService.GetEmployee(userId);
        }

        [HttpPost()]
        [Route("api/Employee/Create")]
        public void CreateEmployee(UserModel u)
        {
            UserService.CreateUser(u);
        }

        // TODO: Update User Route

        [Route("api/Employee/Delete/{userId}")]
        public void DeleteEmployee(int userId)
        {
            UserService.DeleteUser(userId);
        }
    }
}
