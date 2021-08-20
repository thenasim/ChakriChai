using AutoMapper;
using BEL;
using DAL;

namespace BLL.MapperConfig
{
    public class AutoMapperSettings : Profile
    {
        public AutoMapperSettings()
        {
            CreateMap<UserModel, User>();
            CreateMap<ExamModel, Exam>();
            CreateMap<BoardModel, Board>();
            CreateMap<JobPostModel, JobPost>();
            CreateMap<JobPostViewModel, JobPost>();
            CreateMap<ApplyModel, Apply>();
            CreateMap<AcademicModel, Academic>();
            //CreateMap<Academic, AcademicModel>()
            //    //.ForMember(a => a.Exam, a => a.MapFrom(ps => ps.Exam.ExamName));
            //    .AfterMap((a, b) => Mapper.Map(a.Exam, b));
        }
    }
}