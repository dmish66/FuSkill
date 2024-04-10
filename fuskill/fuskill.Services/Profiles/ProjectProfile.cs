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
            CreateMap<Project, ProjectDTO>().ForMember(dest => dest.SkillsIds, opt =>
            {
                opt.MapFrom(p => p.Skills.Select(item => item.Id).ToList());
            }).ReverseMap();

            CreateMap<ProjectDTO, Project>().ForMember(dest => dest.Skills, opt =>
            {
                opt.MapFrom(dto => dto.SkillsIds.Select(item => new Skill()
                {
                    Id = item
                }).ToList()) ;
            });
        }
    }
}
