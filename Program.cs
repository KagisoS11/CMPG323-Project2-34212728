using Microsoft.EntityFrameworkCore;
using EcoPowerLogistics_Project2_API.Controllers;
using Microsoft.Extensions.DependencyInjection;
using EcoPowerLogistics_Project2_API.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<EcoPowerLogistics_Project2_APIContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EcoPowerLogistics_Project2_APIContext") ?? throw new InvalidOperationException("Connection string 'EcoPowerLogistics_Project2_APIContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

//var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
//builder.Services.AddDbContext<DBContext>(options => options.UseSqlServer(connectionString));

