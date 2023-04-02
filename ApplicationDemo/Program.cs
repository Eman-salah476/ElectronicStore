using ApplicationDemo.Core.Services.DeviceService;
using ApplicationDemo.Infrastructure.Context;
using ApplicationDemo.Infrastructure.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContextPool<DataContext>(
            options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataBaseConnection")));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Configure Services
builder.Services.AddTransient<IDeviceService, DeviceService>();
builder.Services.AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>));



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
