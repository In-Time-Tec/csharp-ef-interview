using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeSkills.DataModels;

public class Employee : BaseEntity
{

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Position { get; set; }
    public string Email { get; set; }
    public DateTime EmployeeStartDate { get; set; }
    public virtual ICollection<EmployeeSkill> EmployeeSkills { get; set; }
    
    public virtual ICollection<EmployeeProject> EmployeeProjects { get; set; }
}