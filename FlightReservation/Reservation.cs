using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservation
{
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
		public string Gender { get; set; } // Cinsiyet özelliği eklendi
		public int CustomerAge { get; set; } // Yaş özelliği eklendi
	}
}
