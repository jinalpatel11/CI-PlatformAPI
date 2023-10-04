using CIPlatform_Web_API.Infrastructure;
using CIPlatform_Web_API.Repositories;
using CIPlatform_Web_API.Repositories.Interface;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(option =>
{
    // option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultSQLConnection"));
    option.UseSqlServer("Data Source=DESKTOP-2QFP1NN; Initial Catalog=CIPlatform_API; Trusted_Connection=True; TrustServerCertificate=True;");

});

builder.Services.AddEntityFrameworkSqlServer();
//builder.Services.AddDbContextPool<ApplicationDbContext>((serviceProvider, optionsBuilder) =>
//{
//    optionsBuilder.UseSqlServer(builder.Configuration.GetConnectionString("DefaultSQLConnection"));
//    optionsBuilder.UseInternalServiceProvider(serviceProvider);
//});


// Register your multiple dependencies here
builder.Services.AddScoped<IUserTableRepository, UserTableRepository>();
builder.Services.AddScoped<IDocumentTableRepository, DocumentTableRepository>();
builder.Services.AddScoped<IMissionTableRepository, MissionTableRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Optimizing API performance with techniques like response compression and HTTP/2.
builder.Services.AddResponseCompression(options =>
{
    options.EnableForHttps = true; // Enable compression for HTTPS requests (optional)
});

//Optimizing API performance with techniques like response compression and HTTP/2.
builder.Services.Configure<GzipCompressionProviderOptions>(options =>
{
    options.Level = System.IO.Compression.CompressionLevel.Optimal; // Set compression level (optional)
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();





//Optimizing API performance with techniques like response compression and HTTP/2.
app.UseResponseCompression();

app.UseSwagger(c => c.RouteTemplate = "swagger/{documentName}/swagger.json");
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("v1/swagger.json", "CalistaAPI v1");
}
);

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();
app.UseAuthentication();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});




app.Run();



