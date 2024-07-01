using AutoMapper;
using BusinessObjecs.Mapping;
using JewelryStorePRN221.Services;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Common.Interface;
using Repositories.IRepository;
using Repositories.RepositoryImpl;
using Services.IService;
using Services.ServiceImpl;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
    builder => builder.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader()
    );
});

//service
builder.Services.AddScoped<IUserServices, UserServices>();
builder.Services.AddScoped<IJwtService, JwtService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICounterService, CounterService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IOrderDetailService, OrderDetailService>();
builder.Services.AddScoped<IPromotionService, PromotionService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IVnPayService, VnPayService>();


builder.Services.AddScoped<IUnitOfWork>(provider => provider.GetRequiredService<JeweryStoreDBContext>());

//repo
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IRoleRepository, RoleRepository>();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
builder.Services.AddTransient<ICounterRepository, CounterRepository>();
builder.Services.AddTransient<IOrderRepository, OrderRepository>();
builder.Services.AddTransient<IOrderDetailRepository, OrderDetailRepository>();
builder.Services.AddTransient<IPromotionRepository, PromotionRepository>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();



builder.Services.AddDbContext<JeweryStoreDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

using (var scope = app.Services.CreateScope()) // Create a scope to access the services
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<JeweryStoreDBContext>();
}


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
