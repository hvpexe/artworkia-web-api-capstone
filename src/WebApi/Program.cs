using Application;
using Application.Commons;
using Application.Services.ELK;
using Infrastructure;
using System.Text.Json.Serialization;
using WebApi;
using WebApi.Extensions;
using WebApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddJsonOptions(opt
    => opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddOpenApiDocumentation(); // Add Swagger config

// Bind AppConfiguration from configuration
var config = builder.Configuration.Get<AppConfiguration>();
builder.Configuration.Bind(config);
builder.Services.AddSingleton(config!);

// Add dbcontext middlerware
builder.Services.AddDbContextConfiguration(config!.ConnectionStrings.MSSQLServerDB);

// Add jwt configuration
builder.Services.AddJwtConfiguration(config!);

// Add extensions
builder.Services.AddRepositories();
builder.Services.AddServices();
builder.Services.AddServiceDIs();

// Add DI for IHttpContextAccessor
builder.Services.AddHttpContextAccessor();

// Add auto mapper
builder.Services.AddAutoMapper(typeof(MappingProfile));

// Add Cors
builder.Services.AddCorsPolicy();

// Serilog configuration
//Log.Logger = new LoggerConfiguration()
//      .ReadFrom.Configuration(builder.Configuration).CreateLogger();

//builder.Host.UseSerilog();

builder.Services.AddElasticSearch(builder.Configuration);

Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", @"Credentials/application_default_credentials.json");

// add memory cache
builder.Services.AddMemoryCache();

var app = builder.Build();

// Configure the HTTP request pipeline.
//app.UseSerilogRequestLogging();

app.UseOpenApi(); // use swagger

app.UseHttpsRedirection();

app.UseStaticFiles(); // Use static files

app.UseCorsPolicy(); // Use cors

app.UseAuthentication(); // Use Authentication

app.UseAuthorization();


app.MapControllers();

// using websocket
app.UseWebSockets(new WebSocketOptions
{
    KeepAliveInterval = TimeSpan.FromSeconds(10)
});
app.UseApplyMigrations(); // Apply latest migrations, especially when running in Docker
app.UseInitDataElasticSearch(app.Logger); // Init data for elastic search

app.Run();
