## FlightReservation Project

### Project Overview

FlightReservation is a Windows Forms application designed to manage flight reservations. This project uses Entity Framework Core to handle essential components such as aircraft, locations, and reservations.

### Technologies and Libraries Used

- **.NET 8.0**
- **Entity Framework Core 8.0.6**
  - `Microsoft.EntityFrameworkCore`
  - `Microsoft.EntityFrameworkCore.Design`
  - `Microsoft.EntityFrameworkCore.Sqlite`
- **Newtonsoft.Json 13.0.3**

### Project Structure

- **ApplicationDbContext**: Manages the database context.
- **Aircraft**: Stores aircraft information.
- **Location**: Stores location information.
- **Reservation**: Stores reservation information.
- **Forms**: User interface components (MainForm, AircraftForm, ReservationForm).

### Sample Code


#### Reservation

```csharp:FlightReservation/Reservation.cs

public class Reservation

{

    public int Id { get; set; }

    public int AircraftId { get; set; }

    public Aircraft Aircraft { get; set; }

    public int DepartureLocationId { get; set; }

    public Location DepartureLocation { get; set; }

    public int ArrivalLocationId { get; set; }

    public Location ArrivalLocation { get; set; }

    public DateTime Date { get; set; }

    public TimeSpan Time { get; set; }

    public string SelectedSeat { get; set; }

    public string CustomerName { get; set; }

    public string CustomerSurname { get; set; }

    public string CustomerPhone { get; set; }

    public string CustomerEmail { get; set; }

    public string Gender { get; set; }

    public int Age { get; set; } 

}

```


