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
        }
    }
}