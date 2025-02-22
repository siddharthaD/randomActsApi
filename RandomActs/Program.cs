using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RandomActs.Database;
using RandomActs.SeedData;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<RandomDB>();


builder.Services.AddTransient<DbInitialiser>();


// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

Console.WriteLine("I am building");
using (var scope = app.Services.CreateScope())
{

    var services = scope.ServiceProvider;
    var initialiser = services.GetRequiredService<DbInitialiser>();
    Console.WriteLine("I am initialising");
    initialiser.Run();
}
// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();
// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();



app.Run();