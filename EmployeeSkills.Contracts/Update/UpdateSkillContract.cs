using System.ComponentModel.DataAnnotations;
using EmployeeSkills.Contracts.CreateContracts;

namespace EmployeeSkills.Contracts.UpdateContracts;

public class UpdateSkillContract : CreateSkillContract
{
    [Required]
    public int Id { get; set; }
}