using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserService
    {
        public static List<UserModel> GetAllUser(int limit)
        {
            var data = UserRepo.GetAllUsers(limit);
            var final = AutoMapper.Mapper.Map<List<User>, List<UserModel>>(data);
            return final;
        }

        public static UserModel GetUser(int id)
        {
            var data = UserRepo.GetUser(id);
            var final = AutoMapper.Mapper.Map<User, UserModel>(data);
            return final;
        }

        public static UserModel Login(LoginModel lm)
        {
            var user = new User { Email = lm.Email, Password = lm.Password };
            var data = UserRepo.Login(user);
            var final = AutoMapper.Mapper.Map<User, UserModel>(data);
            return final;
        }

        public static void CreateUser(UserModel u)
        {
            var data = AutoMapper.Mapper.Map<UserModel, User>(u);

            if (u.Role == "EMPLOYEE")
            {
                EmployeeRepo.CreateEmployee(new Employee { User = data });
            }
            else if (u.Role == "EMPLOYEER")
            {
                EmployeerRepo.CreateEmployeer(new Employeer { User = data, YearEstablishment = DateTime.Now });
            }
            else
            {
                UserRepo.CreateUser(data);
            }
        }

        public static void UpdateUser(int userId, UserModel u)
        {
            var data = AutoMapper.Mapper.Map<UserModel, User>(u);
            UserRepo.UpdateUser(userId, data);
        }

        public static void DeleteUser(int id)
        {
            UserRepo.DeleteUser(id);
        }
    }
}
