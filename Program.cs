using BookStoreApi.Models;
using BookStoreApi.Services;
using dotenv.net;

var builder = WebApplication.CreateBuilder(args);

DotEnv.Load(options: new DotEnvOptions(envFilePaths: new[]{".env"}));

var connectionString = Environment.GetEnvironmentVariable("MONGO_CONNECTION_STRING");
Console.WriteLine($"Conexión a MongoDB: {connectionString}"); // Para verificar que se carga bien


// Add services to the container.
builder.Services.Configure<BookStoreDatabaseSettings>(
    options =>{
        options.ConnectionString = connectionString;
        options.DatabaseName = "BookStore";
        options.BooksCollectionName = "Books";
         builder.Configuration.GetSection("BookStoreDatabase");
    }   
);

builder.Services.AddSingleton<BooksService>();

builder.Services.AddControllers()
    .AddJsonOptions(
        options => options.JsonSerializerOptions.PropertyNamingPolicy = null);

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUi(options =>
    {
        options.DocumentPath = "/openapi/v1.json";
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
