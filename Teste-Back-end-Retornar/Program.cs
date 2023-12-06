using Data.Conection;
using Data.Context;
using Domain.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using Repository.Repositorys;
using Services.Generators;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<Contexts>(options => options.UseSqlServer(Conection.StrCon));

builder.Services.AddScoped<IGeneratorService, GeneratorService>();
builder.Services.AddScoped<IGeneratorRepository, GeneretorRepository>();

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
