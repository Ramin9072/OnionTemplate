using Onion.Infrastracture;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
var connection = builder.Configuration.GetConnectionString("Onion");

ArticleCategoryBootstraper.Configure(builder.Services, connection);

var app = builder.Build();

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

