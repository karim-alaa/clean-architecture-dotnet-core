using AutoMapper;
using Models;
using Models.ViewModels;

namespace APIs.AutoMapperConfig
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // Book
            CreateMap<Book, VmBook>();

            // User
            CreateMap<User, VmUser>();
        }
    }
}
