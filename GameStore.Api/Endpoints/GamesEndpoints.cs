using GameStore.Api.Data;
using GameStore.Api.Dtos;
using GameStore.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Api.Endpoints;

public static class GamesEndpoints
{
    const string GetGameEndpointName = "GetName";
   private static readonly List<GameDto> games = [
   new (1, "Street Fighter II", "Fighting", 19.99M, new DateOnly(1992, 7, 15)),
   new (2, "Final Fantasy VII Rebirth", "RPG", 69.99M, new DateOnly(2024, 2, 29)),
   new (3, "Astro Bot", "Platformer", 59.99M, new DateOnly(2024, 9, 6))
];
public static void MapGamesEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/games");
       
// GET /games
group.MapGet("/", async (GameStoreContext dbContext) =>
{
  var games = await dbContext.Games.Include(game => game.Genre).Select(game => new GameSummaryDto(
    game.Id,
    game.Name,
    game.Genre!.Name,
    game.Price,
    game.ReleaseDate
   ))
   .AsNoTracking()
   .ToListAsync();
return Results.Ok(games);
});

// GET /games/{id}
group.MapGet("/{id}", async (int id, GameStoreContext dbContext) => 
{
   var game =  await dbContext.Games.FindAsync(id);
   return game is null ? Results.NotFound(): Results.Ok(
    new GameDetailsDto(
        game.Id,
        game.Name,
        game.GenreId,
        game.Price,
        game.ReleaseDate
    )
   );
    
}
)
.WithName(GetGameEndpointName);
// POST /games
group.MapPost("/", async (CreateGameDto newGame, GameStoreContext dbContext) =>
{
    if (string.IsNullOrEmpty(newGame.Name))
    {
        return Results.BadRequest("Name is required");
    };
    Game game = new()
    {
        Name = newGame.Name,
        GenreId = newGame.GenreId,
        Price = newGame.Price,
        ReleaseDate = newGame.ReleaseDate
    };

    dbContext.Games.Add(game);
     await dbContext.SaveChangesAsync();
GameDetailsDto gameDto = new(
    game.Id,
    game.Name,
    game.GenreId,
    game.Price,
    game.ReleaseDate
);
    return Results.CreatedAtRoute(GetGameEndpointName, new {id = gameDto.Id}, gameDto);
});

// PUT /games/1
group.MapPut("/{id}", async (int id, UpdateGameDto updatedGame, GameStoreContext dbContext) =>
{
    var existingGame = await dbContext.Games.FindAsync(id);
   
    if (existingGame is null)
    {
        return Results.NotFound();
    }
    existingGame.Name = updatedGame.Name;
    existingGame.GenreId = updatedGame.GenreId;
    existingGame.Price = updatedGame.Price;
    existingGame.ReleaseDate = updatedGame.ReleaseDate;
    await dbContext.SaveChangesAsync();

    return Results.NoContent();
});

// DELETE /games/1
group.MapDelete("/{id}", async (int id, GameStoreContext dbContext) =>
{
    await dbContext.Games
    .Where(game => game.Id == id)
    .ExecuteDeleteAsync();
    

    return Results.NoContent();
}); 
    }
}