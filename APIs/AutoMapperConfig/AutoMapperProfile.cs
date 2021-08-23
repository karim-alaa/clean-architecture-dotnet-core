using Models.ViewModels;
using AutoMapper;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIs.AutoMapperConfig
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // ProductGroup
            CreateMap<ProductGroup, VmProductGroup>();
            CreateMap<VmProductGroupCreate, VmProductGroup>();

            // User
            CreateMap<User, VmUser>();
        }
    }
}
