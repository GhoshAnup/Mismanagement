using AutoMapper;
using Mismanagement.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mismanagement.Api
{
    public class ObjectMapper : Profile
    {
        public ObjectMapper()
        {
            CreateMap<Data.Entities.Project, Project>().ReverseMap().ForAllMembers(opt => opt.Ignore());
            CreateMap<Data.Entities.Department, Department>().ReverseMap().ForAllMembers(opt => opt.Ignore());
        }
    }
}
