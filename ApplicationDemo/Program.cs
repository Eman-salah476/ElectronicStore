using ApplicationDemo.Application.Helpers;
using ApplicationDemo.Application.Services;
using ApplicationDemo.Application.Services.Interfaces;
using ApplicationDemo.Domain.Repositories;
using ApplicationDemo.Infrastructure.Presistence.Context;
using ApplicationDemo.Infrastructure.Repositories;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContextPool<DataContext>(
            options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataBaseConnection"),
            x => x.MigrationsAssembly("ApplicationDemo.Infrastructure.Presistence")
            ));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Conifgure AuctoMapper
var mapperConfig = new MapperConfiguration(c =>
{
    c.AddProfile(new MappingProfile());
});
IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

//Configure Services
builder.Services.AddTransient<IDeviceService, DeviceService>();
builder.Services.AddTransient<ICategoryService, CategoryService>();
builder.Services.AddTransient<ILookUpService, BrandService>();
builder.Services.AddTransient<IOfferService, OfferService>();
builder.Services.AddTransient<IOrderService, OrderService>();
//Repositories
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));



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
