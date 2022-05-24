# IntegrationTestDemo

This repository contains examples for selfhosted integration tests for the WeatherForecast web application.

The examples follow this article https://timdeschryver.dev/blog/how-to-test-your-csharp-web-api

## IntegrationTest31

This shows the example in dotnet 3.1

## IntegrationTest60

This shows the example in dotnet 6.0. It has two versions: one with the traditional Program.cs and Startup.cs and a version without Startup.cs, where everything is stored in Program.cs

Note that Program.cs has to be marked as public, in order for the test to be able to access it (https://docs.microsoft.com/en-us/aspnet/core/test/integration-tests?view=aspnetcore-6.0#basic-tests-with-the-default-webapplicationfactory)