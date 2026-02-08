using GameStoreAPI.Data;
using GameStoreAPI.DTO;
using GameStoreAPI.Models;

namespace GameStoreAPI.Endpoints;

public static class GamesEndpoints
{
    
    private const string CGetGameById = "GetGameById"; // can define a name for a particular endpoint to get it referenced by other endpoints.
    // readonly only locks the reference not the data.
    private static readonly List<GameDto> Games =
    [
        new GameDto(1, "Tekken 10", "Fighting", 1904.05m, new DateOnly(2028, 5, 12)),
        new GameDto(2, "Tekken 11", "Fighting", 3904.93m, new DateOnly(2030, 2, 21)),
        new GameDto(3, "Mario More&More", "Casual", 862.93m, new DateOnly(2027, 3, 1)),
        new GameDto(4, "GTA VI", "AAA", 62.93m, new DateOnly(2026, 12, 22)),
    ];

    // this WebApplication app --> this is extension method.
    // Extension method always require static class with static method.
    // first param should contain 'this' keyword
    public static void MapGamesEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/game");
        group.MapGet("/", () => Games);

        group.MapGet("/{id:int}", (int id) =>
        {
            var game = Games.Find(game => game.Id.Equals(id));
            return game is null ? Results.NotFound("Game not found") : Results.Ok(game);
        }).WithName(CGetGameById);

        group.MapPost("/", async (CreateGameDto game, GameStoreContext dbContext) =>
        {
            Game newGame = new()
            {
                Name = game.Name,
                GenreId = game.GenreId,
                Price = game.Price,
                ReleaseDate = game.ReleaseDate
            };
            dbContext.Games.Add(newGame);
            await dbContext.SaveChangesAsync();

            GameDetailsDto gameDetailsDto = new( newGame.Id, newGame.Name, newGame.GenreId, newGame.Price, newGame.ReleaseDate );
            return Results.CreatedAtRoute(CGetGameById, new {id = gameDetailsDto.Id}, gameDetailsDto);
        });

        group.MapPut("/{id:int}", (int id, UpdateGameDto updatedGame) =>
        {
            var index = Games.FindIndex(game => game.Id == id);
            if (index == -1) return Results.NotFound("Game not Found");
            Games[index] = new GameDto(
                id, updatedGame.Name, updatedGame.Genre, updatedGame.Price, updatedGame.ReleaseDate
            );

            return Results.NoContent();
        });

        group.MapDelete("/{id:int}", (int id) =>
        {
            var gameToDelete = Games.FirstOrDefault(game => game.Id == id);
            if (gameToDelete == null) return Results.NotFound("Game not Found");

            Games.Remove(gameToDelete);
            return Results.NoContent();
        });
    }

}