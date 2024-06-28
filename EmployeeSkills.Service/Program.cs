using EmployeeSkills.Business.RestOperationServices;
using EmployeeSkills.Data.RestOperationRepositories;
using EmployeeSkills.DbContext;
using EmployeeSkills.Interfaces.Manager;
using EmployeeSkills.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

IConfigurationBuilder configurationBuilder = new ConfigurationBuilder()
    .SetBasePath(AppContext.BaseDirectory)
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true)
    .AddEnvironmentVariables();

IConfiguration configuration = configurationBuilder.Build();

builder.Services.AddDbContext<DatabaseContext>(options =>
{
    options.UseSqlServer(configuration.GetConnectionString("EmployeeSkillsDb"));
});

builder.Services.AddSingleton(configuration);

builder.Services.AddTransient<IEmployeeManager, EmployeeManager>();
builder.Services.AddTransient<ISkillManager, SkillManager>();
builder.Services.AddTransient<IProjectManager, ProjectManager>();
builder.Services.AddTransient<IEmployeeProjectManager, EmployeeProjectManager>();

builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddTransient<ISkillRepository, SkillRepository>();
builder.Services.AddTransient<IProjectRepository, ProjectRepository>();
builder.Services.AddTransient<IEmployeeProjectRepository, EmployeeProjectRepository>();


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

WebApplication app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
