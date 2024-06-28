using System.ComponentModel.DataAnnotations;


namespace EmployeeSkills.Contracts.CreateContracts;

public class CreateEmployeeContract
{
    [Required]
    [StringLength(50, MinimumLength = 3)]
    public string FirstName { get; set; }

    [Required]
    [StringLength(50, MinimumLength = 3)]
    public string LastName { get; set; }

    [Required]
    [StringLength(50, MinimumLength = 3)]
    public string Position { get; set; }

    [Required]
    [StringLength(80, MinimumLength = 3)]
    public string Email { get; set; }

    public DateTime EmployeeStartDate {get; set;}
}