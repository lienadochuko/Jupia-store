using Entitties;
using Microsoft.EntityFrameworkCore;
using ServiceContract;
using Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();


//add services into IoC container
builder.Services.AddScoped<IGoodsService, GoodsService>();

builder.Services.AddDbContext<GoodsDbContext>(
    options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnections"));
    }
    );

var app = builder.Build();

if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}


app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();
