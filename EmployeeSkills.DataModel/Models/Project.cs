using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmployeeSkills.DataModels
{
    public class Project : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string ProjectName { get; set; }
        
        public virtual ICollection<EmployeeProject> EmployeeProjects { get; set; }
    }
}
