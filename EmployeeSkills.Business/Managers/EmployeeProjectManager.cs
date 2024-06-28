using EmployeeSkills.DataModels;
using EmployeeSkills.Interfaces.Manager;
using EmployeeSkills.Interfaces.Repository;

namespace EmployeeSkills.Business.RestOperationServices;

public class EmployeeProjectManager : IEmployeeProjectManager
{
    private readonly IEmployeeProjectRepository _employeeProjectRepository;

    public EmployeeProjectManager(IEmployeeProjectRepository employeeProjectRepository)
    {
        _employeeProjectRepository = employeeProjectRepository;
    }

    public Task<Project> GetProjectByEmployeeIdAsync(int employeeId)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeProject> CreateEmployeeProjectAsync(EmployeeProject employeeProject)
    {
        throw new NotImplementedException();
    }

    public Task<EmployeeProject> UpdateEmployeeProjectAsync(EmployeeProject employeeProject)
    {
        throw new NotImplementedException();
    }

    public Task DeleteEmployeeProjectByIdAsync(int employeeProjectId)
    {
        throw new NotImplementedException();
    }
}