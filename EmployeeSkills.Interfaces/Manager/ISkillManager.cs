using EmployeeSkills.DataModels;

namespace EmployeeSkills.Interfaces.Manager;

public interface ISkillManager
{
    public Task<IEnumerable<Skill>> GetSkillsAsync();
    public Task<Skill> GetSkillByIdAsync(int id);
    public Task<Skill> AddSkillAsync(Skill skill);
    public Task<Skill> UpdateSkillAsync(Skill skill);
    public Task DeleteSkillByIdAsync(int id);
}