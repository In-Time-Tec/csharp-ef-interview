using EmployeeSkills.DataModels;
using EmployeeSkills.Exceptions;
using EmployeeSkills.Interfaces.Manager;
using EmployeeSkills.Interfaces.Repository;

namespace EmployeeSkills.Business.RestOperationServices;

public class EmployeeManager : IEmployeeManager
{
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeeManager(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }
    
    public Task<List<Employee>> GetEmployeesAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<Employee> GetEmployeeByIdAsync(int id)
    {
        Employee employee = await _employeeRepository.GetEmployeeByIdAsync(id);
        
        if (employee == null)
        {
            throw new EntityNotFoundException($"Employee with id {id} not found");
        }
        
        return employee;
    }

    public async Task<Employee> AddEmployeeAsync(Employee employee)
    {
        return await _employeeRepository.AddEmployeeAsync(employee);
    }

    public async Task<Employee> UpdateEmployeeAsync(Employee employee)
    {
        return await _employeeRepository.UpdateEmployeeAsync(employee);
    }

    public Task DeleteEmployeeByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}