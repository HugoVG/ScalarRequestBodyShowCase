namespace ScalarRequestBodyShowCase;

public class WeatherForecast
{
    /// <summary>
    /// date to set
    /// </summary>
    /// <example>2024-01-01</example> // Overrides the default example
    public DateOnly Date { get; set; }

    /// <summary>
    /// temperature in celsius
    /// </summary>
    /// <example>31</example>
    public int TemperatureC { get; set; }
    /// <summary>
    /// temperature in fahrenheit
    /// </summary>
    /// <example>78</example> // honestly idk if this is right
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    /// <summary>
    ///  summary of the weather
    /// </summary>
    /// <example>Nice and cozy</example>
    public string? Summary { get; set; }
}