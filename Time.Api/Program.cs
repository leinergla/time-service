using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

app.MapOpenApi();

app.MapScalarApiReference();

app.UseHttpsRedirection();

app.MapGet("/time", () =>
{  //returns the current UTC time and the timezone
    return new
    {
        CurrentTime = DateTime.UtcNow,
        TimeZone = "UTC"
    };
});

app.Run();
