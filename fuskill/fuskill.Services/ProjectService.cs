using AutoMapper;
using fuskill.Data.Entities;
using fuskill.Data.Repositories;
using fuskill.Data.Repositories.Abstractions;
using fuskill.Services.Abstractions;
using fuskill.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fuskill.Services
{   
    public class ProjectService : IProjectService
    {
        private readonly ICrudRepository<Project> _projectRepository;
        private readonly ICrudRepository<Skill> _skillRepository;
        private readonly IMapper _mapper;
        public ProjectService(ICrudRepository<Project> projectRepository, ICrudRepository<Skill> skillRepository, IMapper mapper)
        {
            _projectRepository = projectRepository;
            _skillRepository = skillRepository;
            _mapper = mapper;
        }
        
        public async Task AddProjectAsync(ProjectCreateEditDTO model)
        {
            var project = _mapper.Map<Project>(model);
            var skills = model.SkillsIds.Select(item => _skillRepository.GetByIdAsync(item).Result).ToList();
            project.Skills = skills;
            await _projectRepository.AddAsync(project);
        }

        public async Task DeleteProjectByIdAsync(int id)
        {
            await _projectRepository.DeleteByIdAsync(id);
        }

        public async Task<ProjectDTO> GetProjecsByIdAsync(int id)
        {
            var project = await _projectRepository.GetByIdAsync(id);
            return _mapper.Map<ProjectDTO>(project);
        }

        public async Task<List<ProjectDTO>> GetProjectByNameAsync(string name)
        {
            var projects = (await _projectRepository.GetAllAsync()).ToList();
            return _mapper.Map<List<ProjectDTO>>(projects);
        }

        public async Task<List<ProjectDTO>> GetProjectsAsync()
        {
            var projects = (await _projectRepository.GetAllAsync()).ToList();
            return _mapper.Map<List<ProjectDTO>>(projects);
        }

        public async Task UpdateProjectAsync(ProjectCreateEditDTO model)
        {
            var project = _mapper.Map<Project>(model);
            await _projectRepository.UpdateAsync(project);
        }
    }
}
