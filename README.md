## **Overview** 
This API is built using .NET Core 7.0 and utilizes Entity Framework Core for the Object Relational Mapping (ORM) layer. The backend is set up to use MS SQL as the database.  This project can be used to learn how to develop in this environment. Currently the API has foundation for an Employee Skills tracker. The model can be expanded on or changed for your needs.

The API has the following structure:

- **Business**: This project contains classes that represent the core business logic of the API.
- **Service**: This project contains classes that handle incoming HTTP requests and return HTTP responses.
- **Data**: This project contains classes that handle data access, using the Entity Framework Core ORM.
- **Interfaces**: This project contains interfaces that define the contract for various components of the API.
- **UnitTests**: This project contains unit tests for various components of the API.
- **Contracts**: This project contains classes that define the contracts for data transfer between different components of the API.
- **DataModel**: This project contains classes that represent the data models used by the Entity Framework Core ORM and contains classes that represent the database context used by the Entity Framework Core ORM.

## **Getting Started**

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### **Installing**

1. Restore the necessary packages:
```
dotnet restore
```
2. Update the connection string in the appsettings.json file to point to your local database instance.
3. Run the following commands to apply the necessary migrations (if running local instance of DB):
```
dotnet ef database update --project EmployeeSkills.DataModel --startup-project EmployeeSkills.Service
```
4. Add a system environment variable to your system for ASPNETCORE_ENVIRONMENT and set the value to Development


All of these steps should be ran during the setup.sh script on devcontainer initialization

5. Start the API by running:
```
dotnet run --project  EmployeeSkills.Service
```

To use swagger for development:
Go to the ports tab in github codespaces and make the "visibility" on both ports set to "public"
go to: https://${codespace_name}-7146.app.github.dev/swagger/index.html (you can also go to the ports tab in codespaces and ctrl click on the forwarded address on port 7156 and then add "/swagger/index.html" to the URL)


Please Analyze the Codebase and the DB Diagram (link at the bottom of this README)

The following endpoints have been implemented:
### Employee Endpoints
- **`GET api/employees/{id}`**: gets a specific employee by their id ✅
- **`POST api/employees`**: creates a new employee ✅
- **`PUT api/employees/{id}`**: updates an existing employee ✅

### Skill Endpoints
- **`GET api/skills/{id}`**: gets a specific skill by its id ✅
- **`POST api/skills`**: creates a new skill ✅

### Employee Endpoints
- **`GET api/employees`**: gets a list of all employees
- **`DELETE api/employees/{id}`**: deletes an existing employee

### Skill Endpoints
- **`GET api/skills`**: gets a list of all skills
- **`PUT api/skills/{id}`**: updates an existing skill
- **`DELETE api/skills/{id}`**: deletes an existing skill

The following endpoints have NOT been implemented:
### Project Endpoints
- **`GET api/projects`**: gets a list of all projects
- **`GET api/projects/{id}`**: gets a specific project by its id
- **`POST api/projects`**: creates a new project
- **`PUT api/projects/{id}`**: updates an existing project
- **`DELETE api/projects/{id}`**: deletes an existing project

### Employees and Skills (Many-to-Many Relationship)
- **`GET api/employees/{id}/skills`**: gets a list of all skills for a specific employee
- **`DELETE api/employees/{id}/skills/{skill_id}`**: removes a specific skill from an employee
- **`POST api/employees/{id}/skills`**: adds one or more skills to an employee
- **`PUT api/employees/{id}/skills/{skill_id}`**: updates a specific skill on an employee

### Employees and Projects (Many-to-Many Relationship)
- **`GET api/employees/{id}/projects`**: gets a list of all projects for a specific employee
- **`POST api/employees/{id}/projects`**: adds one or more projects to an employee
- **`DELETE api/employees/{id}/projects/{project_id}`**: removes a specific project from an employee
- **`PUT api/employees/{id}/projects/{project_id}`**: updates a specific project on an employee

DB Diagram - https://dbdiagram.io/d/6363fb06c9abfc61117024dd 




SQL Portion:
To connect to the SQL Database, go to the SQL Server Extension on codespaces. Add a connection. It will prompt for a connection string. Please paste the following into there.
Server=localhost,1433;Database=product-db;User Id=sa;Password=MyAdminTest81;TrustServerCertificate=true;