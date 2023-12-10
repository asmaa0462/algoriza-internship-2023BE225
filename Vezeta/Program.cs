using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RepositoryL.Data;
using ServiceL.Repository;
using Domain.Mapper;
using Domain.Entities;
using ServiceL.UnitOfWork.UnitOfWork;
using ServiceL.unitofwork;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

//Configure Unit of Work
builder.Services.AddTransient(typeof(IUnitOfWork),typeof(UnitOfWork));
//Mapper
builder.Services.AddAutoMapper(typeof(AutoMapperConfigProfile));
//Configure EntityFrameWork with SQL Server
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("conn"));
});

//Identity
builder.Services.AddIdentity<IdentityUser,IdentityRole>(Options =>
{
    Options.Password.RequireDigit = true;
    Options.Password.RequireLowercase = true;
    Options.Password.RequiredLength = 8;
}).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();