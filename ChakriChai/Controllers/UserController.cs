﻿using BEL;
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
        public List<UserModel> GetAllStudents(int limit = 10) {
            return UserService.GetAllUser(limit);
        }

        [Route("api/User/Get/{id}")]
        public UserModel Get(int id) {
            return UserService.GetUser(id);
        }

        [HttpPost()]
        [Route("api/User/Add")]
        public void CreateUser(UserModel u)
        {
            UserService.CreateUser(u);
        }

        [HttpDelete()]
        [Route("api/User/Delete/{id}")]
        public void DeleteUser(int id)
        {
            UserService.DeleteUser(id);
        }
    }
}