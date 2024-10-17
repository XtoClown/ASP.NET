using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();


app.UseRouting();
app.MapControllers();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.MapControllerRoute(
                name: "default",
                pattern: "{controller=File}/{action=DownloadFile}/{id?}");


app.Run();
