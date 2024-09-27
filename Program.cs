using lr_four.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddScoped<ILibraryService, LibraryService>();
builder.Configuration.AddJsonFile("bookConfig.json").AddJsonFile("profileConfig.json");

var app = builder.Build();

Book book = new Book();
app.Configuration.Bind(book);

Profile profile = new Profile();
app.Configuration.Bind(profile);

app.UseRouting();
app.MapControllers();

app.Run();
