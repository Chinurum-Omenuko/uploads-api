using uploads_api.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddDbContext<PKContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();       
builder.Services.AddSwaggerGen();                
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();                             
    app.UseSwaggerUI();                           

}

app.UseHttpsRedirection();
app.MapControllers();
app.MapGet("/", () =>
{
    return Results.Ok("It works");
});

app.Run();

