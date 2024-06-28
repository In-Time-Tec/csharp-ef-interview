using EmployeeSkills.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EmployeeSkills.DbContext;

public class DatabaseContext : Microsoft.EntityFrameworkCore.DbContext
{
    public DbSet<Employee> Employees { get; set; }
    
    public DbSet<Skill> Skills { get; set; }
    
    public DbSet<Project> Projects { get; set; }
    
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }
    public override int SaveChanges()
    {
        DateTime currentTime = DateTime.UtcNow;

        foreach (EntityEntry entry in ChangeTracker.Entries())
        {
            if (entry.Entity is BaseEntity entity)
            {
                if (entry.State == EntityState.Added)
                {
                    entity.CreatedAt = currentTime;
                }

                entity.UpdatedAt = currentTime;
            }
        }

        return base.SaveChanges();
    }

}