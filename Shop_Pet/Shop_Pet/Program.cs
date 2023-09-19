using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Shop_Pet.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Shop_PetContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Shop_PetContext")));

builder.Services.AddControllersWithViews();

// Thêm session
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession();
builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(10);
});
builder.Services.AddHttpContextAccessor();
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

// Sử dụng session
app.UseSession();

app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();