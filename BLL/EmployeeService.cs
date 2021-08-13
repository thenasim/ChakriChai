using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EmployeeService
    {
        public static List<UserModel> GetAllEmployee(int limit)
        {
            var data = EmployeeRepo.GetAllEmployees(limit);
            var result = AutoMapper.Mapper.Map<List<User>, List<UserModel>>(data);
            return result;
        }

        public static UserModel GetEmployee(int userId)
        {
            var data = EmployeeRepo.GetEmployee(userId);
            var final = AutoMapper.Mapper.Map<User, UserModel>(data);
            return final;
        }

        public static void DeleteEmployee(int userId)
        {
            EmployeeRepo.DeleteEmployee(userId);
        }
    }
}
