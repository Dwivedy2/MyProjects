using BlogTool.Extentions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.ConfigureSwaggerGen();

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.ConfigureSwaggerDoc();

app.MapControllers();

app.Run();
