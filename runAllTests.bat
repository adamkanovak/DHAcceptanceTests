@echo off
nuget.exe restore DHAcceptanceTests.sln
MSBuild DHAcceptanceTests.sln
packages\NUnit.ConsoleRunner.3.7.0\tools.\nunit3-console.exe DHAcceptanceTests\bin\Debug\DHAcceptanceTests.dll
pause