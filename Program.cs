using lr_one;
using lr_one.Middleware;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Company company = new Company();

company.Name = "Nvidia";
company.Type = "International";
company.Countries = ["USA", "Canada", "Germany", "French", "Great Britain", "East Korea"];
company.Staff = 29600;

app.UseMiddleware<MiddlewareLogic>();
app.Run(async (context) => await context.Response.WriteAsync($"{company}"));
app.Run();
