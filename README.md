# CS_Algorithms Project
Common algorithm implementations in C#.

## Dependencies
* [dotnet cli 2.1.x](https://docs.microsoft.com/en-us/dotnet/core/tools/?tabs=netcore2x)
```
dotnet --version
# 2.1.0-preview1-006703
```

## Project Details
This project was provisioned using the _dotnet new_ command.
```
dotnet new classlib -n "csharpAlgorithms"
dotnet new mstest -n "csharpAlgorithms_Tests"
```

## Getting Started
The below code statement executes Program.cs.

```
cd csharpAlgorithms/

dotnet restore
dotnet build
dotnet run
```

## Tests
The below statement executes all Tests that are annotated with [TestMethod]

```
cd csharpAlgorithms_Tests
dotnet test
```