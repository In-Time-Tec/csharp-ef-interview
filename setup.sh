#!/bin/bash

# Run the Docker image with the specified environment variables and port mappings
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=MyAdminTest81" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2019-latest

# Install the dotnet-ef tool globally
dotnet tool install --global dotnet-ef --version 7.0.7

# Add the dotnet tools to the PATH
export PATH="$PATH:/home/codespace/.dotnet/tools"

# Update the database using Entity Framework
dotnet ef database update --project EmployeeSkills.DataModel --startup-project EmployeeSkills.Service

dotnet dev-certs https --trust

dotnet build