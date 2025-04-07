using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using mvc_agile_process.Data;
using mvc_agile_process.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<mvc_agile_processContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("mvc_agile_processContext") ?? throw new InvalidOperationException("Connection string 'mvc_agile_processContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
