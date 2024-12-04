using InfinityElectronics.Shared;
using InfinityElectronics.Shared.Models;
using InfitinityElectronics.Web.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();  

builder.Services.AddControllers();
builder.Services.AddMemoryCache();

builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();

builder.Services.AddDbContext<ProductApplicationDbContext>();

var app = builder.Build();


using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<ProductApplicationDbContext>();
    dbContext.Database.EnsureCreated();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseSwagger();

// Enable Swagger UI
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "Infinity Electronics API V1");
});

app.MapControllers();

app.Run();
