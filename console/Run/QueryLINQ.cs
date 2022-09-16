using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using console.Contexts;

public class QueryLINQ : IQueryLINQ
{
    private readonly ILogger<QueryLINQ> _logger;
    private readonly IConfiguration _cfg;


    public QueryLINQ(ILogger<QueryLINQ> logger, IConfiguration cfg)
    {
        _logger = logger;
        _cfg = cfg;
    }

    public void RunQueryLINQ()
    {
        using (var ctx = new mydbContext())
        {
            var output = ctx.Earthquakes
                        .OrderBy(x => x.Magnitude)
                        .Take(20)
                        .ToList();


            foreach (var item in output)
            {
                System.Console.WriteLine(item);
                _logger.LogWarning("{num}", item.Cause);
            }
        }
    }
}