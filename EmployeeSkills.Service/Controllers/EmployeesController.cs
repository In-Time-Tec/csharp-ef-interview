using EmployeeSkills.Contracts.BaseContracts;
using EmployeeSkills.Contracts.CreateContracts;
using EmployeeSkills.Contracts.UpdateContracts;
using EmployeeSkills.DataModels;
using EmployeeSkills.Exceptions;
using EmployeeSkills.Interfaces.Manager;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSkills.Service.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeesController : ControllerBase
{
    private readonly IEmployeeManager _employeeManager;
    
    public EmployeesController(IEmployeeManager employeeManager)
    {
        _employeeManager = employeeManager;
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult<BaseResponseContract<Employee>>> GetEmployeeById(int id)
    {
        BaseResponseContract<Employee> response = new BaseResponseContract<Employee>();

        try
        {
            Employee employee = await _employeeManager.GetEmployeeByIdAsync(id);
            
            response.Data = employee;
            response.Message = "Employee found";
            response.Success = true;
            
            return Ok(response);
        }
        catch (EntityNotFoundException e)
        {
            response.Message = e.Message;
            response.Success = false;

            return NotFound(response);
        }
        catch (Exception e)
        {
            response.Message = e.Message;
            response.Success = false;
            
            return StatusCode(StatusCodes.Status500InternalServerError, response);
        }
    }

    [HttpPost]
    public async Task<ActionResult<BaseResponseContract<Employee>>> AddEmployee([FromBody] CreateEmployeeContract createEmployeeContract) {
        BaseResponseContract<Employee> response = new BaseResponseContract<Employee>();

        try {
            Employee employee = new Employee(){
                FirstName = createEmployeeContract.FirstName,
                LastName = createEmployeeContract.LastName,
                Position = createEmployeeContract.Position,
                Email = createEmployeeContract.Email,
                EmployeeStartDate = createEmployeeContract.EmployeeStartDate
            };

            response.Data = await _employeeManager.AddEmployeeAsync(employee);
            response.Success = true;
            response.Message = "Employee created successfully";

            return Ok(response);
        }
        catch (Exception e) {
            response.Success = false;
            response.Message = e.Message;

            return StatusCode(StatusCodes.Status500InternalServerError, response);
        }
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<BaseResponseContract<Employee>>> UpdateEmployee([FromBody] UpdateEmployeeContract updateEmployeeContract, int id) {
        BaseResponseContract<Employee> response = new BaseResponseContract<Employee>();

        try {
            Employee employee = new Employee(){
                Id = id,
                FirstName = updateEmployeeContract.FirstName,
                LastName = updateEmployeeContract.LastName,
                Position = updateEmployeeContract.Position,
                Email = updateEmployeeContract.Email,
                EmployeeStartDate = updateEmployeeContract.EmployeeStartDate
            };

            response.Data = await _employeeManager.UpdateEmployeeAsync(employee);
            response.Success = true;
            response.Message = "Employee updated successfully";

            return Ok(response);
        }
        catch (Exception e) {
            response.Success = false;
            response.Message = e.Message;

            return StatusCode(StatusCodes.Status500InternalServerError, response);
        }
    }

}