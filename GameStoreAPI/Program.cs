using GameStoreAPI.Data;
using GameStoreAPI.Endpoints;

var builder = WebApplication.CreateBuilder(args);
// should be added before calling .Build() method.
builder.Services.AddValidation(); // for adding validation to all the endpoints.

var ConnString = "Data Source=GameStore.db";
builder.Services.AddSqlite<GameStoreContext>(ConnString);

var app = builder.Build();

app.MapGet("/", () => "Hello From ASP.NET Core!");

app.MapGamesEndpoints();

app.Run();
