using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NewNet8Auth.Data;
using NewNet8Auth.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add Authentication
builder.Services.AddAuthentication()
    .AddBearerToken(IdentityConstants.BearerScheme);

// Add Authorization
builder.Services.AddAuthorizationBuilder();

// Configure DbContext
builder.Services
    .AddDbContext<AppDbContext> ( options => 
        options.UseSqlite("Datasource=appdata.db"));

builder.Services.AddIdentityCore<AppUser>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddApiEndpoints();  // this works in tandem with app.MapIdentityApi to produce the Identity endpoints

var app = builder.Build();

app.MapIdentityApi<AppUser>(); // this works in tandem with builder.Services...AddApiEndpoints to produce the Identity endpoints

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
