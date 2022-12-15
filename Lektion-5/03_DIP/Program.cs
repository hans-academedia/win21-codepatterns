using _03_DIP.Contexts;
using _03_DIP.Factories;
using _03_DIP.Handlers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<NoSqlContext>(x => x.UseCosmos(@"AccountEndpoint=https://win21-cosmosdb.documents.azure.com:443/;AccountKey=1hYBKe4mwm5s9GOLfQegl9d8XsacPJS62l25TChjZZ9wlHJL8SspRUasnmkh8zxNB8R7ugvLNIYAACDb3Zl7gw==;", "WIN22"));
builder.Services.AddDbContext<SqlContext>(x => x.UseSqlServer(@"Server=tcp:win21-sqlserver.database.windows.net,1433;Initial Catalog=azure_sql;Persist Security Info=False;User ID=SqlAdmin;Password=BytMig123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"));
builder.Services.AddSingleton<IProductFactory, ProductFactory>();
builder.Services.AddScoped<IProductHandler, ProductHandler>();

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
