namespace RestaurantTables;

public class ReservationResponse
{
    public bool Success { get; set; }
    public Reservation Reservation { get; set; }

    public ReservationResponse(bool success, Reservation reservation)
    {
        Success = success;
        Reservation = reservation;
    }
}