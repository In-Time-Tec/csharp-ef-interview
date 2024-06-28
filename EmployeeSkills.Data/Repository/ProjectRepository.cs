using EmployeeSkills.DataModels;
using EmployeeSkills.DbContext;
using EmployeeSkills.Interfaces.Repository;

namespace EmployeeSkills.Data.RestOperationRepositories;

public class ProjectRepository : IProjectRepository
{
    private readonly DatabaseContext _context;

    public ProjectRepository(DatabaseContext context)
    {
        _context = context;
    }

    public Task<Project> GetProjectsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Project> GetProjectByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Project> AddProjectAsync(Project project)
    {
        throw new NotImplementedException();
    }

    public Task<Project> UpdateProjectAsync(Project project)
    {
        throw new NotImplementedException();
    }

    public Task DeleteProjectByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}