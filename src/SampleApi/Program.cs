using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapScalarApiReference(options =>
{
    options.Title = "A Sample API";
    options.Theme = ScalarTheme.Kepler;
    options.HideClientButton = true;
});

app.UseHttpsRedirection();

app.Run();
