using lr_two.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("testConfiguration.json").AddXmlFile("testConfiguration.xml").AddIniFile("testConfiguration.ini");
builder.Configuration.AddJsonFile("authorInfo.json");
builder.Services.AddTransient<ITestService, TestService>();

var app = builder.Build();

var service = app.Services.GetRequiredService<ITestService>();

app.MapGet("/", () => $"{service.Send()}");
app.MapGet("/author", () => $"{service.InfoAboutAuthor()}");

app.Run();
