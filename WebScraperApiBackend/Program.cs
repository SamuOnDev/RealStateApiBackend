using Microsoft.EntityFrameworkCore;
using WebScraperApiBackend.DataAcces;

var builder = WebApplication.CreateBuilder(args);

// SQL Conection
const string CONNECTIONNAME = "ScraperDB";
var connectionString = builder.Configuration.GetConnectionString(CONNECTIONNAME);

// DB Context
builder.Services.AddDbContext<ScraperDBContext>(options => options.UseSqlServer(connectionString));


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
