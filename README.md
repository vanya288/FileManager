# Test the application 

## Pre-requirements
1. The following instruction is applicable to SSMS (SQL Server Managment Studio) and VS (Visual Studio) software.

## Beginning

1. Download the [source code](https://github.com/vanya288/FileManager). 
2. Open the solution file (Lab1.sln). 

## Laboratory 5

### Install & Run WinAppDriver
1. Download Windows Application Driver installer from <https://github.com/Microsoft/WinAppDriver/releases>.
2. Run the installer on a Windows 10 machine where your application under test is installed and will be tested.
3. Enable [Developer Mode](https://docs.microsoft.com/en-us/windows/uwp/get-started/enable-your-device-for-development) in Windows settings.
4. Run `WinAppDriver.exe` from the installation directory (E.g. `C:\Program Files (x86)\Windows Application Driver`).

### Test the Robot App
1. The Test App source code has been added to [ISRobot](https://github.com/vanya288/FileManager/tree/master/ISRobot) folder.
2. Modify the connection string as it was shown in the [Laboratory 4](#laboratory-4) section.
3. Add or update the service reference as it was shown in the [Laboratory 4](#laboratory-4) section.
4. Build the ISRobot project. 
5. Run the ISRobot.exe (located in the .\ISRobot\bin\Debug folder) file or [Publish & Run](#publish-&-run) it.
6. Specify the test parameters and click Run test button: ![ISRobot app](https://github.com/vanya288/FileManager/blob/master/Instruction/ISRobotApp.PNG).
7. Test example: 
Pary 1: ![Lab 5 test example part 1](https://github.com/vanya288/FileManager/blob/master/Instruction/Lab5_Ivan_Falchuk_1.gif)
Pary 2: ![Lab 5 test example part 2](https://github.com/vanya288/FileManager/blob/master/Instruction/Lab5_Ivan_Falchuk_2.gif)
Pary 3: ![Lab 5 test example part 3](https://github.com/vanya288/FileManager/blob/master/Instruction/Lab5_Ivan_Falchuk_3.gif).

## Laboratory 4
1. The web service source code has been added to [ISWebService_SourceCode](https://github.com/vanya288/FileManager/tree/master/Connected%20Services/ISWebService_SourceCode) folder.
2. Modify the connection string in the [Web.config file](https://github.com/vanya288/FileManager/blob/master/Connected%20Services/ISWebService_SourceCode/Web.config) in order set the connection to database.
3. Build the web service project. 
4. Update the service assembly on the Lab1 project (Connected Services > ISWebService > Update service reference).

### Add the service assembly if not exists
1. Right click on [ISWebService.asmx](https://github.com/vanya288/FileManager/blob/master/Connected%20Services/ISWebService_SourceCode/ISWebService.asmx.cs) file and select View in Browser: ![View in Browser](https://github.com/vanya288/FileManager/blob/master/Instruction/ServiceURL_1.PNG). 
2. Copy the Service URL: ![Service URL](https://github.com/vanya288/FileManager/blob/master/Instruction/ServiceURL_2.PNG). 
3. Right click on Connected Services in the Lab1 project and select Add Service Reference: ![Add Service Reference](https://github.com/vanya288/FileManager/blob/master/Instruction/ConnectedServices_1.PNG).
4. Paste the Service URL: ![Service URL](https://github.com/vanya288/FileManager/blob/master/Instruction/ServiceURL_3.PNG) and click Ok button.

### Service method example - Count by manufacturer
1. CountByManufacturer Web Method (endpoint) - counts the specified manufacturer records by its name: ![CountByManufacturer Web Method](https://github.com/vanya288/FileManager/blob/master/Instruction/CountByMnf_1.PNG).
2. CountByColumnValue service method - counts records with the specified range: ![CountByColumnValue Service Method](https://github.com/vanya288/FileManager/blob/master/Instruction/CountByMnf_2.PNG).
3. countByManufacturer form method (client side) - makes the service SOAP reqest about manufaturers count: ![countByManufacturer Client Method](https://github.com/vanya288/FileManager/blob/master/Instruction/CountByMnf_2.PNG).

## Database configuration 

1. Run the SQL scripts (in SSMS or other software) located in the SQL folder (createDB.sql first).
2. Set the connection string in App.config file.

## Build & Run

1. Build the application. 
2. Start the application. 

## Publish & Run

1. In the project properties choose the Publish tab. 
2. Click Publish Now. 
3. Run the setup.exe file.


