using Crud.Data.Context;
using Crud.Repositories;
using Crud.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(options => {

    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer"));
}, ServiceLifetime.Transient);

builder.Services.AddTransient<UsuariosService>();
builder.Services.AddTransient<UsuariosRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
