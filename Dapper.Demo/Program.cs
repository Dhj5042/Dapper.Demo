using AutoMapper;
using Dapper.DataBase.Data;
using Dapper.Entity.Profiles;
using Dapper.Repository.DapperWrapper;
using Dapper.Repository.IRepository;
using Dapper.Repository.Repository;
using Dapper.Service.IService;
using Dapper.Service.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Add connection
builder.Services.AddDbContext<DataContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});



builder.Services.AddControllers();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IDepartmentRepository, DepartmentRepository>();
builder.Services.AddTransient<IDepartmentService, DepartmentService>();
builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();

builder.Services.AddTransient<IEmployeeService, EmployeeService>();
builder.Services.AddTransient<IDapperWrapper, DapperWrapper>();
var config = new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new MapperConfig());
});
var mapper = config.CreateMapper();
builder.Services.AddSingleton(mapper);
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


