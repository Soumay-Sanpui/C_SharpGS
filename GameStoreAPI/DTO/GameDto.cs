namespace GameStoreAPI.DTO;

/// <summary>
/// Represents a data transfer object for a game.
/// This is a reference-type record that contains data only and no behavior.
/// </summary>
public record class GameDto(
    int Id,
    string Name,
    string Genre,
    decimal Price,
    DateOnly ReleaseDate
);
