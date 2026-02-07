using System.ComponentModel.DataAnnotations;

namespace GameStoreAPI.DTO;

public record class CreateGameDto(
    [Required][StringLength(50)] string  Name, // [Required] is a data annotation.
    [Required][StringLength(20)] string Genre,
    [Range(1,3000)] decimal Price,
    DateOnly ReleaseDate
);
