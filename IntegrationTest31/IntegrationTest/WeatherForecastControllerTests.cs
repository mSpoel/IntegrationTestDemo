using System.Net;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace IntegrationTest
{
    public class WeatherForecastControllerTests : IntegrationTest
    {
        public WeatherForecastControllerTests(ApiWebApplicationFactory fixture)
            : base(fixture) { }

        [Fact]
        public async Task GET_retrieves_weather_forecast()
        {
            var response = await _client.GetAsync("/weatherforecast");
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
