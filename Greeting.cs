using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

public class Greeting : IGreeting
{
    private readonly ILogger<Greeting> _logger;
    private readonly IConfiguration _configuration;

    // private readonly ILogger<Greeting> _logger;
    public Greeting(ILogger<Greeting> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }
    public void Run()
    {
        for (int i = 0; i < _configuration.GetValue<int>("LoopTimes"); i++)
        {
            _logger.LogInformation("Run number {runNumber}", i);
        }
    }
}




