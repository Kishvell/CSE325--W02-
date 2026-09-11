using Microsoft.EntityFrameworkCore;
using W02.Data;

var builder = WebApplication.CreateBuilder(args);

// Add database context
builder.Services.AddDbContext<MvcMovieContext>(options =>
    options.UseSqlite(
        builder.Configuration.GetConnectionString("MvcMovieContext")));

// Add MVC services
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();