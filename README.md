#CS_Algorithms Project

### A simple test runner for CS Dot Net Core ###

### Dependencies ###
* dotnet cli 2.1.x

dotnet net classlib -n "csharpAlgorithms"
dotnet new mstest -n "csharpAlgorithms_Tests"
dotnet add reference "../csharpAlgorithms/csharpAlgorithms.csproj"
dotnet restore
dotnet run
dotnet test