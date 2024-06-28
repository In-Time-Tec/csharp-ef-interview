using EmployeeSkills.DataModels;
using EmployeeSkills.DbContext;
using EmployeeSkills.Interfaces.Repository;

namespace EmployeeSkills.Data.RestOperationRepositories;

public class SkillRepository : ISkillRepository
{
    private readonly DatabaseContext _context;

    public SkillRepository(DatabaseContext context)
    {
        _context = context;
    }

    public Task<IEnumerable<Skill>> GetSkillsAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<Skill> GetSkillByIdAsync(int id)
    {
        return await _context.Skills.FindAsync(id);
    }

    public async Task<Skill> AddSkillAsync(Skill skill)
    {
        _context.Skills.Add(skill);
        _context.SaveChanges();
        return await Task.FromResult(skill);
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