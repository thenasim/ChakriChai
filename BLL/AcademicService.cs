using BEL;
using DAL;
using System.Collections.Generic;

namespace BLL
{
    public class AcademicService
    {
        public static List<AcademicModel> GetAllApplies(int limit)
        {
            var data = AcademicRepo.GetAllAcademics(limit);
            var result = AutoMapper.Mapper.Map<List<Academic>, List<AcademicModel>>(data);
            return result;
        }

        public static List<AcademicModel> GetAcademicsByUser(int userId, int limit)
        {
            var data = AcademicRepo.GetAcademicsByUser(userId, limit);
            var result = AutoMapper.Mapper.Map<List<Academic>, List<AcademicModel>>(data);
            return result;
        }

        public static AcademicModel GetAcademic(int academicId)
        {
            var data = AcademicRepo.GetAcademic(academicId);
            var result = AutoMapper.Mapper.Map<Academic, AcademicModel>(data);
            return result;
        }

        public static bool CreateAcademic(int userId, AcademicModel ac)
        {
            var data = AutoMapper.Mapper.Map<AcademicModel, Academic>(ac);
            return AcademicRepo.CreateAcademic(userId, data);
        }

        public static bool UpdateAcademic(int academicId, AcademicModel ac)
        {
            var data = AutoMapper.Mapper.Map<AcademicModel, Academic>(ac);
            return AcademicRepo.UpdateAcademic(academicId, data);
        }

        public static bool DeleteAcademic(int id)
        {
            return AcademicRepo.DeleteAcademic(id);
        }
    }
}