using Xunit;
using vscode_devdays_2025.ApiService;

public class WeatherForecastServiceTests
{
    [Fact]
    public void GetForecast_ReturnsFiveForecasts_AndUsesSummaries()
    {
        // Arrange
        var summaries = new[] { "Hot", "Cold", "Warm" };
        var service = new WeatherForecastService();

        // Act
        var result = service.GetForecast(summaries);

        // Assert
        Assert.Equal(5, result.Length);
        foreach (var forecast in result)
        {
            Assert.Contains(forecast.Summary, summaries);
        }
    }
}
