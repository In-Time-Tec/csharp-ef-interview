using EmployeeSkills.DataModels;
using EmployeeSkills.Exceptions;
using EmployeeSkills.Interfaces.Manager;
using EmployeeSkills.Interfaces.Repository;

namespace EmployeeSkills.Business.RestOperationServices;

public class SkillManager : ISkillManager
{
    private readonly ISkillRepository _skillRepository;

    public SkillManager(ISkillRepository skillRepository)
    {
        _skillRepository = skillRepository;
    }

    public Task<IEnumerable<Skill>> GetSkillsAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<Skill> GetSkillByIdAsync(int id)
    {
        Skill skill = await _skillRepository.GetSkillByIdAsync(id);
        
        if (skill == null)
        {
            throw new EntityNotFoundException($"Skill with id {id} not found");
        }
        
        return skill;
    }

    public async Task<Skill> AddSkillAsync(Skill skill)
    {
        return await _skillRepository.AddSkillAsync(skill);
    }

    public Task<Skill> UpdateSkillAsync(Skill skill)
    {
        throw new NotImplementedException();
    }

    public Task DeleteSkillByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}