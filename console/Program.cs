using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;

var builder = new ConfigurationBuilder();

StartUp.BuildConfig(builder);

Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(builder.Build())
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .CreateLogger();

var host = Host.CreateDefaultBuilder()
            .ConfigureServices((ctx,services)=>
            {
                services.AddTransient<IGreeting, Greeting>();
                services.AddTransient<IQueryLINQ, QueryLINQ>();
            })
            .UseSerilog()
            .Build();
var go = ActivatorUtilities.CreateInstance<QueryLINQ>(host.Services);

// svc.RunGreeting();
go.RunQueryLINQ();


