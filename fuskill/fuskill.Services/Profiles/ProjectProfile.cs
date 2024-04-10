using AutoMapper;
using fuskill.Data.Entities;
using fuskill.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fuskill.Services.Profiles
{
    public class ProjectProfile : Profile
    {
        public ProjectProfile() {
            CreateMap<Project, ProjectCreateEditDTO>().ReverseMap();
            CreateMap<Project, ProjectDTO>().ReverseMap();
        }
    }
}
