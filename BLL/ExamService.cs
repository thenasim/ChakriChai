using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ExamService
    {
        public static List<ExamModel> GetAllExams()
        {
            var data = ExamRepo.GetAllExams();
            var result = AutoMapper.Mapper.Map<List<Exam>, List<ExamModel>>(data);
            return result;
        }

        public static ExamModel GetExam(int id)
        {
            var data = ExamRepo.GetExam(id);
            var result = AutoMapper.Mapper.Map<Exam, ExamModel>(data);
            return result;
        }

        public static void CreateExam(ExamModel e)
        {
            var data = AutoMapper.Mapper.Map<ExamModel, Exam>(e);
            ExamRepo.CreateExam(data);
        }

        public static void DeleteExam(int id)
        {
            ExamRepo.DeleteExam(id);
        }
    }
}
