using lesson1.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ShirtStoreManagement"));
});
// Add services to the container.
builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();



