using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fuskill.Services.DTOs;

namespace fuskill.Services.Abstractions
{
    public interface IProjectService
    {
        Task<List<ProjectDTO>> GetProjectsAsync();
        Task<ProjectDTO> GetProjecsByIdAsync(int id);
        Task<List<ProjectDTO>> GetProjectByNameAsync(string name);
        Task AddProjectAsync(ProjectDTO model);
        Task DeleteProjectByIdAsync(int id);
        Task UpdateProjectAsync(ProjectDTO model);
    }
}
