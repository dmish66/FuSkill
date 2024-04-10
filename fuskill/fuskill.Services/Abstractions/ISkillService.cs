using fuskill.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fuskill.Services.Abstractions
{
    public interface ISkillService
    {
        Task<List<SkillDTO>> GetSkillsAsync();
        Task<SkillDTO> GetSkillsByIdAsync(int id);
        Task<List<SkillDTO>> GetSkillByNameAsync(string name);
        Task AddSkillAsync(SkillDTO model);
        Task DeleteSkillByIdAsync(int id);
        Task UpdateSkillAsync(SkillDTO model);
    }
}
