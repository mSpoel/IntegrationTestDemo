using System.Net;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using WebApplication;
using Xunit;

namespace IntegrationTest
{
    public class SimpleTest
    {
        [Fact]
        public async Task GET_retrieves_weather_forecast()
        {
            await using var application = new WebApplicationFactory<Program>();
            using var client = application.CreateClient();

            var response = await client.GetAsync("/weatherforecast");
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
