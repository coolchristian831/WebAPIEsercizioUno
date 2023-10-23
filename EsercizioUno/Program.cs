using EsercizioUno.DataSource;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


//INJECTION STRINGA DI CONNESSIONE
builder.Services.AddDbContext<EsercizioUnoContext>(options =>
{
    //modo 1
    string? cnVenditaLibri = builder.Configuration.GetConnectionString("cnNW");
    //modo 2
    //string cnNorthwind2 = builder.Configuration.GetValue<string>("ConnectionStrings:cnMagazzino");

    options.UseSqlServer(cnVenditaLibri);

});


//Inject istanza del data source (context di EF)
builder.Services.AddScoped<EsercizioUnoContext, EsercizioUnoContext>();
//builder.Services.AddScoped<IProdottiService, ProdottiService>();
//builder.Services.AddScoped<IProdottiRepository, ProdottiRepository>();





//MIDDLEWARE

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
