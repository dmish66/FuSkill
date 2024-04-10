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
    public class SkillProfile : Profile
    {
        public SkillProfile() { 
            CreateMap<Skill, SkillDTO>().ReverseMap();
        }
    }
}
