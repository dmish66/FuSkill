using AutoMapper;
using fuskill.Data.Entities;
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
    public class SkillService : ISkillService
    {

        private readonly ICrudRepository<Skill> _repository;
        private readonly IMapper _mapper;
        public SkillService(ICrudRepository<Skill> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task AddSkillAsync(SkillDTO model)
        {
            var skill = _mapper.Map<Skill>(model);
            await _repository.AddAsync(skill);
        }

        public async Task DeleteSkillByIdAsync(int id)
        {
            await _repository.DeleteByIdAsync(id);
        }

        public async Task<List<SkillDTO>> GetSkillByNameAsync(string name)
        {
            var skills = await _repository.GetAsync(item => item.Name == name);
            return _mapper.Map<List<SkillDTO>>(skills);
        }

        public async Task<List<SkillDTO>> GetSkillsAsync()
        {
            var skills = (await _repository.GetAllAsync()).ToList();
            return _mapper.Map<List<SkillDTO>>(skills);
        }

        public async Task<SkillDTO> GetSkillsByIdAsync(int id)
        {
            var skill = await _repository.GetByIdAsync(id);
            return _mapper.Map<SkillDTO>(skill);
        }

        public async Task UpdateSkillAsync(SkillDTO model)
        {
            var skill = _mapper.Map<Skill>(model);
            await _repository.UpdateAsync(skill);
        }
    }
}
