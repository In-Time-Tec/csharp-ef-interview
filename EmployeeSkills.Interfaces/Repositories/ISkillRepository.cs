using EmployeeSkills.DataModels;

namespace EmployeeSkills.Interfaces.Repository;

public interface ISkillRepository
{
    public Task<IEnumerable<Skill>> GetSkillsAsync();
    public Task<Skill> GetSkillByIdAsync(int id);
    public Task<Skill> AddSkillAsync(Skill skill);
    public Task<Skill> UpdateSkillAsync(Skill skill);
    public Task DeleteSkillByIdAsync(int id);
}