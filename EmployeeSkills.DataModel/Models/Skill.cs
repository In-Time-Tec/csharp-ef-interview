using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmployeeSkills.DataModels
{
    public class Skill : BaseEntity
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Level { get; set; }

        public string Type { get; set; }

        public virtual ICollection<EmployeeSkill> EmployeeSkills { get; set; }
        
    }
}
