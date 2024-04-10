using fuskill.Data.Entities;
using fuskill.Data.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fuskill.Data.Repositories
{
    public class ProjectRepository : CrudRepository<Project>, IProjectRepository
    {
        private readonly ApplicationDbContext _context;
        public ProjectRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task UpdateProject(Project project)
        {
            //TODO
            await UpdateAsync(project);
        }
    }
}
