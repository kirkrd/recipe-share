using Microsoft.EntityFrameworkCore;
using Recipe_GraphQL_Client.Data;
using Recipe_GraphQL_Client.Interfaces;
using Recipe_GraphQL_Client.Repositories;

var builder = WebApplication.CreateBuilder(args);

ConfigurationManager configuration = builder.Configuration;

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<IAuthorReposiitory, AuthorRepository>();
builder.Services.AddScoped<IRecipeRepository, RecipeRepository>();
builder.Services.AddScoped<IIngredientRepository, IngredientRepository>();
builder.Services.AddGraphQLServer().AddQueryType<Query>().AddProjections().AddFiltering().AddSorting();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(configuration.GetConnectionString("SqlServer")));

// CORS
var cors = Environment.GetEnvironmentVariable("CORS");
var origins = cors?.Split(',', StringSplitOptions.RemoveEmptyEntries);

if (origins == null || origins.Length == 0)
{
    origins = new string[] { "http://localhost", "http://localhost:3000" };
}

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
    builder =>
    {
        builder.WithOrigins(origins)
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGraphQLHttp("/graphql");

app.Run();
