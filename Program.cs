using Microsoft.EntityFrameworkCore;
using Sistema_Web.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// BD
builder.Services.AddDbContext<DbClienteContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SistemaWebConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

// Criar a BD / Tabelas
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<DbClienteContext>();
    context.Database.EnsureCreated();
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
