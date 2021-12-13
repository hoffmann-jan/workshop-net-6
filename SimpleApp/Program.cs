var builder = WebApplication.CreateBuilder();

var app = builder.Build();

app.MapGet("/", () => "Hallo");

app.Run();

