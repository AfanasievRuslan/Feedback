using Feedback.Application;
using Feedback.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApplication();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

connectionString = string.Format(connectionString,
    Environment.GetEnvironmentVariable("DB_SERVER") ?? "localhost",
    Environment.GetEnvironmentVariable("DB_PORT") ?? "1433",
    Environment.GetEnvironmentVariable("DB_NAME") ?? "FeedbackDb",
    Environment.GetEnvironmentVariable("DB_USER") ?? "sa",
    Environment.GetEnvironmentVariable("DB_PASSWORD") ?? "yourStrong(!)Password",
    Environment.GetEnvironmentVariable("TRUSTED_CONNECTION") ?? "False",
    Environment.GetEnvironmentVariable("TRUST_SERVER_CERTIFICATE") ?? "True"
    );

builder.Services.AddInfrastructure(connectionString);

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
