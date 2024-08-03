using AutoMapper;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models.LeaveTypes;

namespace LeaveManagement.Web.Configurations
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<LeaveType, LeaveTypeReadOnlyVM>();

            CreateMap<LeaveTypeCreateVM, LeaveType>();

            CreateMap<LeaveTypeEditVM, LeaveType>().ReverseMap();
        }
    }
}
