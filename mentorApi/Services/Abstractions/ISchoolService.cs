using mentorApi.DTOs.SchoolDTOs;
using mentorApi.Models;

namespace mentorApi.Services.Abstractions
{
    public interface ISchoolService
    {
        public Task<ResponseModel<List<SchoolGetDTO>>> GetAllSchool();
        public Task<ResponseModel<SchoolGetDTO>> GetAllSchoolById(int Id);
        public Task<ResponseModel<SchoolUpdateDTO>> UpdateSchool(SchoolUpdateDTO schoolUpdateDTO);
        public Task<ResponseModel<bool>> DeleteSchool(int Id); 
        public Task<ResponseModel<SchoolCreateDTO>> CreateSchool(SchoolCreateDTO schoolCreateDTO); 



    }
}