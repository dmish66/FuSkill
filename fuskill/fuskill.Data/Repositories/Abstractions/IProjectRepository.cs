using fuskill.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fuskill.Data.Repositories.Abstractions
{
    public interface IProjectRepository : ICrudRepository<Project>
    {
        public Task UpdateProject(Project project);
    }
}
