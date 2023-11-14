using ServiceContract;
using Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();


//add services into IoC container
builder.Services.AddSingleton<IGoodsService, GoodsService>();

var app = builder.Build();

if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();
