using AdvancedDatabaseAndORMConcepts.Data;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AdventureWorksLT2017Context>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("AdventureWorksLT2017ConnectionString"));
});

builder.Services.Configure<JsonOptions>(options => {
    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});
var app = builder.Build();

app.Run();
