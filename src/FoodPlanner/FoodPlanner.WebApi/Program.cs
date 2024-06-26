using DinkToPdf.Contracts;
using DinkToPdf;
using FoodManager.Shared.Extensions;
using FoodPlanner.BusinessLogic.Interfaces;
using FoodPlanner.BusinessLogic.Services;
using FoodPlanner.DataAccess.Implementations;
using FoodPlanner.DataAccess.Interfaces;
using FoodPlanner.MessageBroker;
using Microsoft.EntityFrameworkCore;
using FoodPlanner.DataAccess;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddEnvironmentVariables("FoodPlanner_");

builder.Services.AddLogging();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGenWithBarerAuth();

builder.Services.AddHttpMessageHandlers();
builder.Services.AddHttpServiceClient(options =>
{
    options.ServiceName = "UserAuthApi";
    options.ConnectionString = builder.Configuration.GetConnectionString("UserAuthApi");
    options.AuthenticationType = AuthenticationType.ApiKey;
    options.AuthServiceName = "UserAuthApi";
    options.ApiKey = builder.Configuration.GetValue<string>("ApiKey");
});
builder.Services.AddHttpServiceClient(options =>
{
    options.ServiceName = "FoodStorageApi";
    options.ConnectionString = builder.Configuration.GetConnectionString("FoodStorageApi");
    options.AuthenticationType = AuthenticationType.ApiKey;
    options.AuthServiceName = "UserAuthApi";    
    options.ApiKey = builder.Configuration.GetValue<string>("ApiKey");
});

builder.Services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));

builder.Services.AddHttpClient<IStorageRepository, StorageRepository>("FoodStorageApi");
builder.Services.AddHttpClient<IUnitOfWork, UnitOfWork>("FoodStorageApi");
builder.Services.AddScoped<IPdfService, PdfService>();
builder.Services.AddScoped<IReportService, ReportService>();
builder.Services.AddScoped<IRabbitMqProducer, RabbitMqProduce>();

builder.Services.AddDbContext<InMemoryDbContext>(options =>
{
    options.UseInMemoryDatabase("FoodPlannerDb");
});
builder.Services.AddScoped<IReportRepository, ReportRepository>();
builder.Services.AddScoped<IReportStorageSerivce, ReportStorageSerivce>();

builder.ConfigureAuthentication();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "FoodPlanner API v1");
        options.RoutePrefix = string.Empty;
    });
}

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}/{id?}");

app.Run();