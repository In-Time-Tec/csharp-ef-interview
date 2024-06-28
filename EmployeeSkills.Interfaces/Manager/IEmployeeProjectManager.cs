using EmployeeSkills.DataModels;

namespace EmployeeSkills.Interfaces.Manager;

public interface IEmployeeProjectManager
{
    public Task<Project> GetProjectByEmployeeIdAsync(int employeeId);
    public Task<EmployeeProject> CreateEmployeeProjectAsync(EmployeeProject employeeProject);
    public Task<EmployeeProject> UpdateEmployeeProjectAsync(EmployeeProject employeeProject);
    public Task DeleteEmployeeProjectByIdAsync(int employeeProjectId);
}