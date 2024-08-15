

using DemoLynn.Models;
using DemoLynn.Models.InternalModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Se configura el DbContext [DemoLynn] y la Connection String [DemoLynn]
builder.Services.AddDbContext<DEMOLYNNContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DemoLynn")));

ConnectionStrings.Provider = builder.Configuration.GetSection("ConnectionStrings");

// Add services to the container.
builder.Services.AddControllersWithViews();

// Registrar los servicios de Kendo UI
builder.Services.AddKendo();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
