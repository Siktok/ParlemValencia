using Microsoft.AspNetCore.Connections;
using Microsoft.OpenApi.Models;
using ParlemValencia.Business.Core;
using ParlemValencia.Business.Entity;
using ParlemValencia.Business.Interfaces;
using ParlemValencia.Infrastructure.Interfaces;
using ParlemValencia.Infrastructure.Repository;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Web Api Parlem Valenciá",
        Version = "v1",
        Description = "WebApi para Parlem Telecom",
        Contact = new OpenApiContact
        {
            Name = "Azael Llanos",
            Email = "azael1992sp@gmail.com",
            Url = new Uri("https://www.linkedin.com/in/azael-llanos-gonzalez/")

        }

    });
});

//Inyección de dependencias aplicacion
builder.Services.AddSingleton<IData, Data>();
builder.Services.AddScoped<IRepositoryClientes, RepositoryClientes>();
builder.Services.AddScoped<IClienteCore, ClienteCore>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

    // Configure the HTTP request pipeline.

    app.UseAuthorization();

app.MapControllers();

app.Run();
