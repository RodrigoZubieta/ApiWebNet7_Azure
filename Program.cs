using Microsoft.EntityFrameworkCore;
using WepApiNet7.Data;
using WepApiNet7.Interface;
using WepApiNet7.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//configuration DbContext
builder.Services.AddDbContext<StoreDbContext>(
     options =>
     {
         options.UseSqlServer(builder.Configuration.GetConnectionString("Defaultconnection"));
     }
    );

//Dependecy Injection
builder.Services.AddTransient<IProductService, ProductService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
