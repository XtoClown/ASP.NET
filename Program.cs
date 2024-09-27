using lr_five.Middleware;
using Serilog;

var builder = WebApplication.CreateBuilder(args);



Log.Logger = new LoggerConfiguration()
    .WriteTo.File(@"D:\5 SEMESTR\ASP.NET\lr_five\logs\logFile.log", 
    outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Properties}{Exception}\n")
    .CreateLogger();

builder.Host.UseSerilog();

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

app.UseMiddleware<ErrorHandlingMiddleware>();

app.UseRouting();
app.MapControllers();
app.UseHttpsRedirection();


app.Run();
Log.CloseAndFlush();