using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using p4s10.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<p4s10DbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("p4s10DbContext") ?? throw new InvalidOperationException("Connection string 'p4s10DbContext' not found.")));

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
