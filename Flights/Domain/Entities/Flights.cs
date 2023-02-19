namespace Flights.Domain.Entities
{
    public record Flights(
        Guid Id,
        string Airline,
        string Price,
        TimePlace Departure,
        TimePlace Arrival,
        int RemainingNumberOfSeats
        );
}
