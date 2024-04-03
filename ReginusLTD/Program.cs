using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ReginusLTD.Areas.Identity.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("ReginusContextDbConnection") ?? throw new InvalidOperationException("Connection string 'ReginusContextDbConnection' not found.");

builder.Services.AddDbContext<ReginusContextDb>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<ReginusLTDUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<ReginusContextDb>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
