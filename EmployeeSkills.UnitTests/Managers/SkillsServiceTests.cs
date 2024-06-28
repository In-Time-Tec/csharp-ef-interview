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
    public class SkillsServiceTests
    {
        private readonly Fixture _fixture = new();
        private readonly Mock<ISkillRepository> _skillRepositoryMock;
        private readonly SkillManager _skillManager;

        public SkillsServiceTests()
        {
            _skillRepositoryMock = new Mock<ISkillRepository>();
            _skillManager = new SkillManager(_skillRepositoryMock.Object);
        }


        [Fact]
        public void Given_EmployeeExists_When_GettingEmployeeById_Then_EmployeeIsReturned()
        {
            var id = _fixture.Create<int>();
            var skill = _fixture.Create<Skill>();
            
            _skillRepositoryMock.Setup(x => x.GetSkillByIdAsync(id)).ReturnsAsync(skill);

            var expectedResult = JsonConvert.SerializeObject(skill);
            var actualResult = JsonConvert.SerializeObject(_skillManager.GetSkillByIdAsync(id).Result);
            
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
