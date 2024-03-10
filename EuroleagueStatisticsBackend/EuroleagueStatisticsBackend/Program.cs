using EuroleagueStatisticsBackend.Data;
using EuroleagueStatisticsBackend.Data.Updates;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<StatisticsDbContext>();

var app = builder.Build();

app.Map("/", async context =>
{
    var dbContext = context.RequestServices.GetRequiredService<StatisticsDbContext>();
    InitialUpdateModule initialUpdateModule = new InitialUpdateModule(dbContext);
    await initialUpdateModule.UpdateAsync();
});

app.Run();