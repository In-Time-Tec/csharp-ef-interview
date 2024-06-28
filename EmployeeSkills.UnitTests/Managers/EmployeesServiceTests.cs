using AutoFixture;
using EmployeeSkills.DataModels;
using EmployeeSkills.Business.RestOperationServices;
using EmployeeSkills.Exceptions;
using EmployeeSkills.Interfaces.Manager;
using EmployeeSkills.Interfaces.Repository;
using Moq;
using Newtonsoft.Json;


namespace EmployeeSkills.UnitTests.Services
{
    public class EmployeesServiceTests
    {
        private readonly Fixture _fixture = new();
        private readonly Mock<IEmployeeRepository> _employeeRepositoryMock;
        private readonly EmployeeManager _employeeManager;

        public EmployeesServiceTests()
        {
            _employeeRepositoryMock = new Mock<IEmployeeRepository>();
            _employeeManager = new EmployeeManager(_employeeRepositoryMock.Object);
        }


        [Fact]
        public void Given_EmployeeExists_When_GettingEmployeeById_Then_EmployeeIsReturned()
        {
            var id = _fixture.Create<int>();
            var employee = _fixture.Create<Employee>();
            
            _employeeRepositoryMock.Setup(x => x.GetEmployeeByIdAsync(id)).ReturnsAsync(employee);

            var expectedResult = JsonConvert.SerializeObject(employee);
            var actualResult = JsonConvert.SerializeObject(_employeeManager.GetEmployeeByIdAsync(id).Result);
            
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void Given_EmployeeIsAdded_When_CreateEmployee_Then_EmployeeIsReturned()
        {
            Employee employee = new Employee {
              FirstName = "Tommy",
              LastName = "Tester",
              Position = "Bean Counter",
              Email = "tommy.tester@hotmail.com"
            };
            
            _employeeRepositoryMock.Setup(x => x.AddEmployeeAsync(employee)).ReturnsAsync(employee);

            var expectedResult = JsonConvert.SerializeObject(employee);
            var actualResult = JsonConvert.SerializeObject(_employeeManager.AddEmployeeAsync(employee).Result);
            
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void Given_EmployeeIsUpdated_When_UpdateEmployee_Then_EmployeeIsReturned()
        {
            Employee employee = new Employee {
              FirstName = "Tommy",
              LastName = "Tester",
              Position = "Bean Counter",
              Email = "tommy.tester@hotmail.com"
            };
            
            _employeeRepositoryMock.Setup(x => x.UpdateEmployeeAsync(employee)).ReturnsAsync(employee);

            var expectedResult = JsonConvert.SerializeObject(employee);
            var actualResult = JsonConvert.SerializeObject(_employeeManager.UpdateEmployeeAsync(employee).Result);
            
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
