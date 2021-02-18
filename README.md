# stryker-mutator-hello-world

This demo is intended to show where traditional code coverage may show 100% coverage, but stryker is able to test the quality of those tests.

To create these projects yourself:

```bash
mkdir dotnet
cd dotnet
mkdir Calculator
mkdir Calculator.Tests
cd Calculator
dotnet new classlib
cd ../Calculator.Tests
dotnet new xunit
dotnet add reference ../Calculator/Calculator.csproj
dotnet add package coverlet.collector --version 3.0.2
dotnet add package FluentAssertions --version 5.10.3
dotnet new tool-manifest
dotnet tool install dotnet-reportgenerator-globaltool
dotnet tool install dotnet-stryker
```
You may need to restart vscode for intellisense to pick up the new packages.

Write your code and your tests, then run the code coverage tool and generate the coverage report.

```bash
cd ./dotnet/StrykerDemo.Tests/
dotnet test --collect:"XPlat Code Coverage"
dotnet reportgenerator -reports:./TestResults/**/*.xml -targetdir:./TestResults/CoverageReport/ -reporttypes:Html
```

And then run stryker.

```bash
dotnet stryker
```

You can open both of these coverage reports in your browser. `/dotnet/StrykerDemo.Tests/TestResults/CoverageReport/index.html` and `/dotnet/StrykerDemo.Tests/StrykerOutput/*/reports/mutation-report.html`.