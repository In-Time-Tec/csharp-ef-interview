using EmployeeSkills.DataModels;

namespace EmployeeSkills.Interfaces.Repository;

public interface IEmployeeRepository
{
    public Task<List<Employee>> GetEmployeesAsync();
    public Task<Employee> GetEmployeeByIdAsync(int id);
    public Task<Employee> AddEmployeeAsync(Employee employee);
    public Task<Employee> UpdateEmployeeAsync(Employee employee);
    public Task DeleteEmployeeByIdAsync(int id);
}