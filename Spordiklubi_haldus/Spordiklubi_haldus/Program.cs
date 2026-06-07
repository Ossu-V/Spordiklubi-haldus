using Microsoft.EntityFrameworkCore;
using Spordiklubi_haldus.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("SpordiklubiHaldusContext") ?? throw new InvalidOperationException("Connection string 'SpordiklubiHaldusContext' not found.");

builder.Services.AddDbContext<SpordiklubiHaldusContext>(options =>
{
    options.UseInMemoryDatabase("SpordiklubiDb");
});

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
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


// See blokk käivitab andmete algistamise mälusisesse baasi
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<Spordiklubi_haldus.Data.SpordiklubiHaldusContext>();

    // Kutsume välja sinu DbInitializeri
    Spordiklubi_haldus.Data.DbInitializer.Initialize(context);
}

app.Run();