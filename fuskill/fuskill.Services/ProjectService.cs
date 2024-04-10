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
        private readonly ICrudRepository<Project> _repository;

        private readonly IMapper _mapper;
        public ProjectService(ICrudRepository<Project> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        public async Task AddProjectAsync(ProjectDTO model)
        {
            var project = _mapper.Map<Project>(model);
            await _repository.AddAsync(project);
        }

        public async Task DeleteProjectByIdAsync(int id)
        {
            await _repository.DeleteByIdAsync(id);
        }

        public async Task<ProjectDTO> GetProjecsByIdAsync(int id)
        {
            var project = await _repository.GetByIdAsync(id);
            return _mapper.Map<ProjectDTO>(project);
        }

        public async Task<List<ProjectDTO>> GetProjectByNameAsync(string name)
        {
            var projects = (await _repository.GetAllAsync()).ToList();
            return _mapper.Map<List<ProjectDTO>>(projects);
        }

        public async Task<List<ProjectDTO>> GetProjectsAsync()
        {
            var projects = (await _repository.GetAllAsync()).ToList();
            return _mapper.Map<List<ProjectDTO>>(projects);
        }

        public async Task UpdateProjectAsync(ProjectDTO model)
        {
            var project = _mapper.Map<Project>(model);
            await _repository.UpdateAsync(project);
        }
    }
}
