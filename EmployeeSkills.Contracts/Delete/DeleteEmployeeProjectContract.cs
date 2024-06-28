using System.ComponentModel.DataAnnotations;

namespace EmployeeSkills.Contracts.DeleteContracts;

public class DeleteEmployeeProjectContract
{
    [Required]
    public int EmployeeId { get; set; }
    
    [Required]
    public int ProjectId { get; set; }
}