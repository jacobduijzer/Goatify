var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddEndpointsApiExplorer()
    .AddSwaggerGen();

var app = builder.Build();
app
    .UseSwagger()
    .UseSwaggerUI();

app.MapGet("/", () => "Hello World!");

app.Run();