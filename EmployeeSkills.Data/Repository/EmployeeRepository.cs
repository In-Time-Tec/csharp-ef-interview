using EmployeeSkills.DataModels;
using EmployeeSkills.DbContext;
using EmployeeSkills.Interfaces.Repository;

namespace EmployeeSkills.Data.RestOperationRepositories;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly DatabaseContext _context;

    public EmployeeRepository(DatabaseContext context)
    {
        _context = context;
    }
    
    public Task<List<Employee>> GetEmployeesAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<Employee> GetEmployeeByIdAsync(int id)
    {
        return await _context.Employees.FindAsync(id);
    }

    public async Task<Employee> AddEmployeeAsync(Employee employee)
    {
        _context.Employees.Add(employee);
        _context.SaveChanges();
        return await Task.FromResult(employee);
    }

    public async Task<Employee> UpdateEmployeeAsync(Employee employee)
    {
        Employee updatedEmployee = _context.Employees.First(e => e.Id == employee.Id);
        updatedEmployee.FirstName = employee.FirstName;
        updatedEmployee.LastName = employee.LastName;
        updatedEmployee.Position = employee.Position;
        updatedEmployee.Email = employee.Email;
        updatedEmployee.EmployeeStartDate = employee.EmployeeStartDate;
        _context.SaveChanges();
        return await Task.FromResult(updatedEmployee);
    }

    public Task DeleteEmployeeByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}