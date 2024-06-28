using System.ComponentModel.DataAnnotations;

namespace EmployeeSkills.Contracts.CreateContracts;

public class CreateSkillContract
{
    [Required]
    [StringLength(50, MinimumLength = 3)]
    public string Name { get; set; }

    [Required]
    public int Level { get; set; }

    [Required]
    [StringLength(50, MinimumLength = 3)]
    public string Type { get; set; }
}