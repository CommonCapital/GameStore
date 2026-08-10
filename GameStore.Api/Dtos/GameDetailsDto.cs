namespace GameStore.Api.Dtos;

// A DTO IS A CONTRACT BETWEEN CLIENT AND SERVER SIDES THAT REPRESENTS A SHARED AGREEMENT ABOUT HOW THE DATA WILL BE TRANSFERRED AND USED.
public record GameDetailsDto(
    int Id,
    string Name,
    int GenreId,
    decimal Price,
    DateOnly ReleaseDate
);
