## HOW TO SETUP DATABASE AND MIGRATIONS

Before doing these steps make sure to already have the docker-compose built and running in order for the sql server service exists and be running, if not, of course a connection error will be throwned.

Inside the Infrastructure project we have the folder "Persistence/Migrations" inside there is the migration files needed to set up the database.

1. Open the project in visual studio and set the Api project as startup project.
2. Inside the appsettings.json file uncomment the connection string that says is used to run migrations and comment the other one
3. Open the nuget packages terminal and setting the Infrastrucre project as target run the following command:
<code>Update-Database</code>
4. The database should be created successfully

The credentials for the SQL Server are configured in the docker-compose.yml file, those credentials are:
- Username: sa
- Password: Local1234

## HOW TO SETUP AND RUN APPLICATION

Make sure to have docker desktop installed on the computer in order to be able to follow these steps.

1. First open the terminal in the root of the project
2. Build the docker images running the following command:
   <code>docker-compose build</code>
   This will build both the .net api and the sql server image.
3. Now, run the following command in order to start the container and run the application:
   <code>docker-compose up</code>
4. Done! The application is up and running on "https://localhost:5001"

To access swagger enter "https://localhost:5001/swagger/index.html"
The employees endpoints are:

#1. POST -> https://localhost:5001/api/employee
#2. GET -> https://localhost:5001/api/employee

The front-end application is already configured to use "https://localhost:5001/api" as the backend api url.

## DESCRIPTION

This is back-end application made with .NET 7 for the Solvo assessment where we need an api with two endpoints: One for creating employees and another to list the stored ones.
To persist the information I'm using SQL Server.
The application is using the CQRS architecture. following best practices of abstraction and naming conventions.
