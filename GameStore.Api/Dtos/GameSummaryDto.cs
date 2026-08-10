using GameStore.Api.Models;

namespace GameStore.Api.Dtos;

// A DTO IS A CONTRACT BETWEEN CLIENT AND SERVER SIDES THAT REPRESENTS A SHARED AGREEMENT ABOUT HOW THE DATA WILL BE TRANSFERRED AND USED.
public record GameSummaryDto(
    int Id,
    string Name,
    string Genre,
    decimal Price,
    DateOnly ReleaseDate
);
