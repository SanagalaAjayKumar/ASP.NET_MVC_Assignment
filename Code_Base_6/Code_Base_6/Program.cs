using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Code_Base_6.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Code_Base_6Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Code_Base_6Context") ?? throw new InvalidOperationException("Connection string 'Code_Base_6Context' not found.")));

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
app.UseCors(Builder => Builder
                     .AllowAnyOrigin()
                     .AllowAnyMethod()
                     .AllowAnyHeader());

app.MapControllers();

app.Run();
