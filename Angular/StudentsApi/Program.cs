using Microsoft.EntityFrameworkCore;
using StudentsApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();

builder.Services.AddControllers();

builder.Services.AddDbContext<StudentContext>(opt =>
    opt.UseInMemoryDatabase("StudentList"));

var app = builder.Build();

app.UseCors(options =>
    options.WithOrigins("http://localhost:4200")
           .AllowAnyMethod()
           .AllowAnyHeader());

app.UseAuthorization();

app.MapControllers();

app.Run();