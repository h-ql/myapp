using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

public class Greeting : IGreeting
{
    private readonly ILogger<Greeting> _logger;
    private readonly IConfiguration _configuration;


    public Greeting(ILogger<Greeting> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }
    public void RunGreeting()
    {
        for (int i = 0; i < 10; i++)
        {
            System.Console.WriteLine("{num}", i);
            System.Console.WriteLine("Greeting folks!");
        }


    }
}




