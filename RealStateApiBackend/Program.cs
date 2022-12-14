using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using System.Net;
using System.Security.Claims;
using RealStateApiBackend.DataAcces;
using RealStateApiBackend.Services.JWT;
using RealStateApiBackend.Services.User;

var builder = WebApplication.CreateBuilder(args);

// SQL Conection
const string CONNECTIONNAME = "ScraperDB";
var connectionString = builder.Configuration.GetConnectionString(CONNECTIONNAME);

// DB Context
builder.Services.AddDbContext<RealStateDBContext>(options => options.UseSqlServer(connectionString));

// Service of JWT Autorization
builder.Services.AddJwtTokenServices(builder.Configuration);

// Authorization
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("UserOnlyPolicy", policy => policy.RequireClaim(ClaimTypes.Role, "User"));
});

// Add services to the container.

builder.Services.AddControllers();

// Custom Services
builder.Services.AddScoped<IUserService, UserService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
// Config Swagger to take care of Autorization of JWT
builder.Services.AddSwaggerGen( options =>
{
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme 
    {
        Name = "Authorization",
        Type = SecuritySchemeType.Http, 
        Scheme = "Bearer", 
        BearerFormat = "JWT", 
        In = ParameterLocation.Header, 
        Description = "JWT Authorization Header using Bearer Scheme"
    });

    options.AddSecurityRequirement(new OpenApiSecurityRequirement 
    {
        {
            new OpenApiSecurityScheme
                {
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                    }
                },
            new string[]{}
        }
    });
});

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "CorsPolicy", builder => 
    {
        builder.AllowAnyOrigin();
        builder.AllowAnyMethod();
        builder.AllowAnyHeader();
    });
});

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

app.UseCors("CorsPolicy");

app.Run();
