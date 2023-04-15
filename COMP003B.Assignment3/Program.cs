using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
var builder = WebApplication.CreateBuilder(args);

if(builder.Environment.IsDevelopment())
{
    builder.Services.AddDbContext<MvcEmployeeContext>(options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("MvcEmployeeContext")));
}
else
{
    builder.Services.AddDbContext<MvcEmployeeContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ProductionMvcEmployeeContext")));
}

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Employee}/{action=Index}/{id?}");

app.Run();
