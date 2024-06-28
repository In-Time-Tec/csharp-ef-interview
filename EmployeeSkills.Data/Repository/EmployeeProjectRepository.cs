using EmployeeSkills.DataModels;
using EmployeeSkills.DbContext;
using EmployeeSkills.Interfaces.Repository;

namespace EmployeeSkills.Data.RestOperationRepositories;

public class EmployeeProjectRepository : IEmployeeProjectRepository
{
    private readonly DatabaseContext _context;

    public EmployeeProjectRepository(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<Project> GetProjectByEmployeeIdAsync(int employeeId)
    {
        throw new NotImplementedException();
    }

    public async Task<EmployeeProject> CreateEmployeeProjectAsync(EmployeeProject employeeProject)
    {
        throw new NotImplementedException();
    }

    public async Task<EmployeeProject> UpdateEmployeeProjectAsync(EmployeeProject employeeProject)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteEmployeeProjectByIdAsync(int employeeProjectId)
    {
        throw new NotImplementedException();
    }
}