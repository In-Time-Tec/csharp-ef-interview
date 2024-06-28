using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeSkills.DataModels;

public class EmployeeProject : BaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [ForeignKey("Employee")]
    public int EmployeeId { get; set; }

    [ForeignKey("Project")]
    public int ProjectId { get; set; }

}