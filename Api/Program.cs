using Api.Data;
using Api.Mutations;
using Api.Queries;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services
        .AddGraphQLServer()
        .AddQueryType<ProductQuery>()
        .AddMutationType<ProductMutation>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();


app.MapGraphQL("/graphql");
app.UseHttpsRedirection();
app.Run();
