using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ApplyService
    {
        public static List<ApplyModel> GetAllApplies(int limit)
        {
            var data = ApplyRepo.GetAllApplies(limit);
            var result = AutoMapper.Mapper.Map<List<Apply>, List<ApplyModel>>(data);
            return result;
        }

        public static List<ApplyModel> GetAllAppliesByUser(int userId, int limit)
        {
            var data = ApplyRepo.GetAppliesByUser(userId, limit);
            var result = AutoMapper.Mapper.Map<List<Apply>, List<ApplyModel>>(data);
            return result;
        }

        public static List<ApplyModel> GetAllAppliesByJobPost(int jobPostId, int limit)
        {
            var data = ApplyRepo.GetAppliesByJobPost(jobPostId, limit);
            var result = AutoMapper.Mapper.Map<List<Apply>, List<ApplyModel>>(data);
            return result;
        }

        public static ApplyModel GetApply(int id)
        {
            var data = ApplyRepo.GetApply(id);
            var result = AutoMapper.Mapper.Map<Apply, ApplyModel>(data);
            return result;
        }

        public static bool CreateApply(int userId, int jobPostId, ApplyModel ap)
        {
            var data = AutoMapper.Mapper.Map<ApplyModel, Apply>(ap);
            return ApplyRepo.CreateApply(userId, jobPostId, data);
        }

        public static bool UpdateApply(int applyId, ApplyModel ap)
        {
            var data = AutoMapper.Mapper.Map<ApplyModel, Apply>(ap);
            return ApplyRepo.UpdateApply(applyId, data);
        }

        public static bool DeleteApply(int id)
        {
            return ApplyRepo.DeleteApply(id);
        }
    }
}
