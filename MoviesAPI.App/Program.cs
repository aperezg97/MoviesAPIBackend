using Microsoft.EntityFrameworkCore;

using MoviesAPI.Persistence.DbContexts;
using MoviesAPI.Core.DI;
using MoviesAPI.Persistence.DI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MovieDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MoviesAppDatabase"), b => b.MigrationsAssembly("MoviesAPI.Migrations"));
    options.EnableSensitiveDataLogging();
});

builder.Services.AddPersistenceServices();
builder.Services.AddCoreServices();

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
