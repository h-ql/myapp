using Microsoft.Extensions.Configuration;


public static class StartUp
{
    public static void BuildConfig(IConfigurationBuilder builder)
    {
        builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIROnMENT") ?? "Production"}.json",
                    optional: true)
                .AddEnvironmentVariables();
        
    }
}