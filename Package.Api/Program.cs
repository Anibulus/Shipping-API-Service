using Package.Api.Extensions;

DotNetEnv.Env.Load();
string dhl_url = Environment.GetEnvironmentVariable("DHL_URL") ?? "";
Console.WriteLine("Hello, World!");
Console.WriteLine(dhl_url);


var builder = WebApplication.CreateBuilder(args);
builder.LoadServices();
// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();
