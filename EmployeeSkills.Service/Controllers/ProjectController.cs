using EmployeeSkills.DataModels;
using EmployeeSkills.Interfaces.Manager;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSkills.Service.Controllers;
[ApiController]
[Route("api/[controller]")]
public class ProjectController : ControllerBase
{
    private readonly IProjectManager _projectManager;
    
    public ProjectController(IProjectManager projectManager)
    {
        _projectManager = projectManager;
    }
    
    
}