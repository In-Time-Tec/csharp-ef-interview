using EmployeeSkills.DataModels;

namespace EmployeeSkills.Interfaces.Repository;

public interface IProjectRepository
{
    public Task<Project> GetProjectsAsync();
    public Task<Project> GetProjectByIdAsync(int id);
    public Task<Project> AddProjectAsync(Project project);
    public Task<Project> UpdateProjectAsync(Project project);
    public Task DeleteProjectByIdAsync(int id);
}