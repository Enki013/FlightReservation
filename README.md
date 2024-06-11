## FlightReservation Projesi

### Proje Tanıtımı

FlightReservation, uçak rezervasyonlarını yönetmek için geliştirilmiş bir Windows Forms uygulamasıdır. Bu proje, uçaklar, lokasyonlar ve rezervasyonlar gibi temel bileşenleri yönetmek için Entity Framework Core kullanır.

### Kullanılan Teknolojiler ve Kütüphaneler

- **.NET 8.0**

- **Entity Framework Core 8.0.6**

  - `Microsoft.EntityFrameworkCore`

  - `Microsoft.EntityFrameworkCore.Design`

  - `Microsoft.EntityFrameworkCore.Sqlite`

- **Newtonsoft.Json 13.0.3**

### Proje Yapısı

- **ApplicationDbContext**: Veritabanı bağlamını yönetir.

- **Aircraft**: Uçak bilgilerini tutar.

- **Location**: Lokasyon bilgilerini tutar.

- **Reservation**: Rezervasyon bilgilerini tutar.

- **Forms**: Kullanıcı arayüzü bileşenleri (MainForm, AircraftForm, ReservationForm).

### Örnek Kodlar

#### ApplicationDbContext

```csharp:FlightReservation/ApplicationDBContext.cs

protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

{

    string dbPath = "reservation.db";

    if (!optionsBuilder.IsConfigured)

    {

        optionsBuilder.UseSqlite($"Data Source={dbPath}");

    }

    // Ensure the database is created

    Database.EnsureCreated();

}

```

#### Reservation Sınıfı

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


