using System.ComponentModel.DataAnnotations;

namespace GameStoreAPI.DTO;

public record class UpdateGameDto(
    [Required][StringLength(50)] string  Name,
    [Required][StringLength(20)] string Genre,
    [Range(1,3000)] decimal Price,
    DateOnly ReleaseDate
);
