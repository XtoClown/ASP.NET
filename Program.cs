using lr_three.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddScoped<ICalcService, CalcService>();
builder.Services.AddTransient<IDayTimeInfo, DayTimeInfo>();


var app = builder.Build();

app.UseRouting();
app.MapControllers();

app.Run();
