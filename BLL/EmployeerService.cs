using BEL;
using DAL;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class EmployeerService
    {
        public static List<UserModel> GetAllEmployeer(int limit)
        {
            var data = EmployeerRepo.GetAllEmployeers(limit);
            var result = AutoMapper.Mapper.Map<List<User>, List<UserModel>>(data);
            return result;
        }

        public static UserModel GetEmployeer(int userId)
        {
            var data = EmployeerRepo.GetEmployeer(userId);
            var final = AutoMapper.Mapper.Map<User, UserModel>(data);
            return final;
        }

        public static bool UpdateEmployeer(int userId, EmployeerModel emp)
        {
            var data = AutoMapper.Mapper.Map<EmployeerModel, Employeer>(emp);
            return EmployeerRepo.UpdateEmployeerDetails(userId, data);
        }

        public static EmployeerModel GetEmployeerDetails(int userId)
        {
            var data = EmployeerRepo.GetEmployeerDetails(userId);
            var final = AutoMapper.Mapper.Map<Employeer, EmployeerModel>(data);
            return final;
        }

        public static void DeleteEmployeer(int userId)
        {
            EmployeerRepo.DeleteEmployeer(userId);
        }
    }
}