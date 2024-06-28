namespace EmployeeSkills.Exceptions;

public class EntityNotFoundException : Exception
{
    public string Message { get; set; }
    
    public EntityNotFoundException(string message) : base(message)
    {
        Message = message;
    }
}