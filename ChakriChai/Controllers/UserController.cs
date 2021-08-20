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
    public class UserController : ApiController
    {
        [Route("api/User/GetAll/{limit?}")]
        public List<UserModel> GetAllUser(int limit = 10) {
            return UserService.GetAllUser(limit);
        }

        [HttpPost()]
        [Route("api/User/login")]
        public IHttpActionResult Login(LoginModel lm)
        {
            UserModel user = UserService.Login(lm);
            if (user == null) {
                return Ok(new ErrMsg("User no found"));
            }

            return Ok(user);
        }

        [Route("api/User/Get/{id}")]
        public UserModel Get(int id) {
            return UserService.GetUser(id);
        }

        [HttpPost()]
        [Route("api/User/Create")]
        public void CreateUser(UserModel u)
        {
            UserService.CreateUser(u);
        }

        // TODO: Update User Route

        [Route("api/User/Delete/{id}")]
        public void DeleteUser(int id)
        {
            UserService.DeleteUser(id);
        }
    }
}
