using API.Data;
using Core.Interfaces;
using Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

builder.Services.AddDbContext<DataContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
}
);

builder.Services.AddOpenApi();

builder.Services.AddScoped<IBattleStatRepository,BattleStatRepository>();
builder.Services.AddScoped<IBattleStatRepository,BattleStatRepository>();
builder.Services.AddScoped<IBattleStatRepository,BattleStatRepository>();
builder.Services.AddScoped<IStockRepository,StockRepository>();
builder.Services.AddScoped<IWorkStatRepository,WorkStatRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
