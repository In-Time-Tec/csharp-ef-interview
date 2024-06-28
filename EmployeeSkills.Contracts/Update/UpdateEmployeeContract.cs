using System.ComponentModel.DataAnnotations;
using EmployeeSkills.Contracts.CreateContracts;

namespace EmployeeSkills.Contracts.UpdateContracts;

public class UpdateEmployeeContract : CreateEmployeeContract
{
    [Required]
    public int Id { get; set; }
}