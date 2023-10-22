using AutoMapper;
using mentorApi.DTOs.SchoolDTOs;
using mentorApi.DTOs.StudentsDTOs;
using mentorApi.Entities;

namespace mentorApi.AutoMapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {

            CreateMap<Student, StudentGetDTO>()
                .ForMember(dest => dest.SchoolName, opt => opt.MapFrom(src => src.School.Name))
                .ReverseMap();

            CreateMap<School, SchoolGetDTO>().ReverseMap();
            
        }
    }
}
