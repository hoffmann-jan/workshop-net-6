using ApiSample.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<ApiSample.Services.HugeDataService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapGet("mini/hello", (string name) => {
    return $"Hello {name}!";
}).WithTags("Example");

app.MapPost("mini/person", (Person person) => {
    return new Response {
        Message = $"Hello {person.Firstname} {person.Lastname}!"
    };
})
.WithTags("Example")
.Accepts<Person>("application/json", "text/plain")
.Produces<Response>(200, "application/json", "text/csv");

app.MapControllers();

app.Run();
