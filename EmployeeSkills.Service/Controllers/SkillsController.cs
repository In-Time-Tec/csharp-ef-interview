using EmployeeSkills.Contracts.BaseContracts;
using EmployeeSkills.Contracts.CreateContracts;
using EmployeeSkills.DataModels;
using EmployeeSkills.Interfaces.Manager;
using Microsoft.AspNetCore.Mvc;
using EmployeeSkills.Exceptions;

namespace EmployeeSkills.Service.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SkillsController : ControllerBase
{
    private readonly ISkillManager _skillManager;
    
    public SkillsController(ISkillManager skillManager)
    {
        _skillManager = skillManager;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<BaseResponseContract<Skill>>> GetSkillById(int id)
    {
        BaseResponseContract<Skill> response = new BaseResponseContract<Skill>();

        try
        {
            Skill skill = await _skillManager.GetSkillByIdAsync(id);
            
            response.Data = skill;
            response.Message = "Skill found";
            response.Success = true;
            
            return Ok(response);
        }
        catch (EntityNotFoundException e)
        {
            response.Message = e.Message;
            response.Success = false;

            return NotFound(response);
        }
        catch (Exception e)
        {
            response.Message = e.Message;
            response.Success = false;
            
            return StatusCode(StatusCodes.Status500InternalServerError, response);
        }
    }
    
    [HttpPost]
    public async Task<ActionResult<BaseResponseContract<Skill>>> CreateNewSkill([FromBody] CreateSkillContract createSkillContract)
    {
        BaseResponseContract<Skill> response = new BaseResponseContract<Skill>();
        
        try
        {
            Skill skill = new Skill()
            {
                Name = createSkillContract.Name,
                Level = createSkillContract.Level,
                Type = createSkillContract.Type
            };
            
            response.Data = await _skillManager.AddSkillAsync(skill);
            response.Success = true;
            response.Message = "Skill created successfully";
            
            return Ok(response);
        }
        catch (Exception e)
        {
            response.Success = false;
            response.Message = e.Message;
            
            return StatusCode(StatusCodes.Status500InternalServerError, response);
        }
    }
}