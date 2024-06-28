using EmployeeSkills.DataModels;
using EmployeeSkills.Interfaces.Manager;
using EmployeeSkills.Interfaces.Repository;

namespace EmployeeSkills.Business.RestOperationServices;

public class ProjectManager : IProjectManager
{
    private readonly IProjectRepository _projectRepository;

    public ProjectManager(IProjectRepository projectRepository)
    {
        _projectRepository = projectRepository;
    }

    public Task<Project> GetProjectsAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<Project> GetProjectByIdAsync(int id)
    {
        return await _projectRepository.GetProjectByIdAsync(id);
    }

    public async Task<Project> AddProjectAsync(Project project)
    {
        return await _projectRepository.AddProjectAsync(project);
    }

    public async Task<Project> UpdateProjectAsync(Project project)
    {
        return await _projectRepository.UpdateProjectAsync(project);
    }

    public Task DeleteProjectByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}