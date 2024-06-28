using EmployeeSkills.Contracts.DeleteContracts;
using EmployeeSkills.DataModels;
using EmployeeSkills.Interfaces.Manager;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSkills.Service.Controllers;

public class EmployeeProjectsController
{
    private readonly IEmployeeProjectManager _employeeProjectManager;

     public EmployeeProjectsController(IEmployeeProjectManager employeeProjectManager)
    {
        _employeeProjectManager = employeeProjectManager;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Project>>> GetProjectsByEmployeeId(int employeeId)
    {
        throw new NotImplementedException();
    }

    [HttpDelete]
    public async Task<ActionResult> DeleteProject(
        [FromBody] DeleteEmployeeProjectContract deleteEmployeeProjectContract)
    {
        throw new NotImplementedException();
    }
}