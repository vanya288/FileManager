# Test the application 

## Pre-requirements
1. The following instruction is applicable to SSMS (SQL Server Managment Studio) and VS (Visual Studio) software.

## Beginning

1. Download the [source code](https://github.com/vanya288/FileManager). 
2. Open the solution file (Lab1.sln). 

## Laboratory 4
1. The web service source code has been added to [ISWebService_SourceCode](https://github.com/vanya288/FileManager/tree/master/Connected%20Services/ISWebService_SourceCode) folder.
2. Modify the connection string in the [Web.config file](https://github.com/vanya288/FileManager/blob/master/Connected%20Services/ISWebService_SourceCode/Web.config) in order set the connection to database.
3. Build the web service project. 
4. Update the service assembly on the Lab1 project (Connected Services > ISWebService > Update service reference).

## Database configuration 

1. Run the SQL scripts (in SSMS or other software) located in the SQL folder (createDB.sql first).
2. Set the connection string in App.config file.

## Build & run

1. Build the application. 
2. Start the application. 

## Publish & run

1. In the project properties choose the Publish tab. 
2. Click Publish Now. 
3. Run the setup.exe file.


