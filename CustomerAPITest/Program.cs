
using MediatR;
using Application;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Serilog;

Log.Logger = new LoggerConfiguration()
            .WriteTo.Console().CreateLogger();

Log.Information("Application Starting up");
try
{
 
    var builder = WebApplication.CreateBuilder(args);

    //Confgiure Serilog
    var logconfig = new ConfigurationBuilder().AddJsonFile("logConfig.json", optional: true, reloadOnChange: true).Build();
    builder.Host.UseSerilog((ctx, lc) => lc.WriteTo.Console().ReadFrom.Configuration(logconfig));


    // Add services to the container.
    builder.Services.AddControllers();
    builder.Services.AddApplicationServicesReg();
    builder.Services.AddPersistanceServicesReg();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    var app = builder.Build();

    // Configure the HTTP request pipeline.
   
        app.UseSwagger();
        app.UseSwaggerUI();
    

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, " Unhandled exception occured while Starting up");

    //Add exec loggin
}

