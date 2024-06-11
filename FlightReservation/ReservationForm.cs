using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;

namespace FlightReservation
{
	public partial class ReservationForm : Form
	{
		private ApplicationDbContext _context;
		private bool _isUpdating = false;

		public ReservationForm()
		{
			InitializeComponent();
			_context = new ApplicationDbContext();
			LoadReservations();
			LoadAircrafts();
			LoadLocations();
			LoadSeats(); // Koltukları yükle
			comboBoxAircrafts.SelectedIndexChanged += comboBoxAircrafts_SelectedIndexChanged;
		}

		private void LoadReservations()
		{
			var reservations = _context.Reservations.Include(r => r.Aircraft).Include(r => r.DepartureLocation).Include(r => r.ArrivalLocation).ToList();
			dataGridViewReservations.DataSource = reservations;
		}

		private void LoadAircrafts()
		{
			var aircrafts = _context.Aircrafts.ToList();
			comboBoxAircrafts.DataSource = aircrafts;
			comboBoxAircrafts.DisplayMember = "Model";
			comboBoxAircrafts.ValueMember = "Id";
		}

		private void LoadLocations()
		{
			var locations = _context.Locations.ToList();
			var departureLocations = locations.ToList(); // Yeni bir liste oluştur
			var arrivalLocations = locations.ToList(); // Yeni bir liste oluştur

			comboBoxDeparture.DataSource = departureLocations;
			comboBoxDeparture.DisplayMember = "City";
			comboBoxDeparture.ValueMember = "Id";

			comboBoxArrival.DataSource = arrivalLocations;
			comboBoxArrival.DisplayMember = "City";
			comboBoxArrival.ValueMember = "Id";
		}

		private void LoadSeats()
		{
			if (comboBoxAircrafts.SelectedValue != null && int.TryParse(comboBoxAircrafts.SelectedValue.ToString(), out int selectedAircraftId))
			{
				var selectedAircraft = _context.Aircrafts.FirstOrDefault(a => a.Id == selectedAircraftId);
				if (selectedAircraft != null)
				{
					panelSeats.Controls.Clear(); // Paneli temizle
					int seatCapacity = selectedAircraft.SeatCapacity;
					MessageBox.Show($"Seat Capacity: {seatCapacity}"); // Hata ayıklama mesajı
					var seatStatus = GetSeatStatusFromDatabase(selectedAircraftId);

					int panelWidth = panelSeats.Width;
					int buttonWidth = panelWidth / 20; // 20 koltuk sığacak şekilde genişlik ayarla
					int buttonHeight = 30; // Sabit yükseklik
					int margin = 2; // Butonlar arası boşluk

					int x = margin; // Başlangıç x koordinatı
					int y = margin; // Başlangıç y koordinatı

					for (int i = 1; i <= seatCapacity; i++)
					{
						string seatNumber = $"{i}";
						bool isAvailable = !seatStatus.ContainsKey(seatNumber) || seatStatus[seatNumber] == "Available";
						Button btnSeat = new Button
						{
							Text = seatNumber, // Koltuk numarasını göster
							BackColor = isAvailable ? Color.Green : Color.Red,
							Width = buttonWidth,
							Height = buttonHeight,
							Location = new Point(x, y),
							Margin = new Padding(margin)
						};
						btnSeat.Click += BtnSeat_Click;
						panelSeats.Controls.Add(btnSeat);

						x += buttonWidth + margin;
						if (x + buttonWidth > panelWidth)
						{
							x = margin; // Yeni satır için x koordinatını sıfırla
							y += buttonHeight + margin; // Yeni satır için y koordinatını artır
						}
					}
				}
			}
		}


		private Dictionary<string, string> GetSeatStatusFromDatabase(int aircraftId)
			{
				var seatStatus = new Dictionary<string, string>();

				var reservations = _context.Reservations
					.Where(r => r.AircraftId == aircraftId)
					.ToList();

				foreach (var reservation in reservations)
				{
					seatStatus[reservation.SelectedSeat] = "Sold";
				}

				return seatStatus;
			}

		private void btnAddReservation_Click(object sender, EventArgs e)
		{
			var reservation = new Reservation
			{
				AircraftId = (int)comboBoxAircrafts.SelectedValue,
				DepartureLocationId = (int)comboBoxDeparture.SelectedValue,
				ArrivalLocationId = (int)comboBoxArrival.SelectedValue,
				Date = dateTimePickerDate.Value,
				Time = dateTimePickerTime.Value.TimeOfDay,
				SelectedSeat = GetSelectedSeat(), // Seçilen koltuk
				CustomerName = txtCustomerName.Text,
				CustomerSurname = txtCustomerSurname.Text,
				CustomerPhone = txtCustomerPhone.Text,
				CustomerEmail = txtCustomerEmail.Text,
				Gender = comboBoxGender.SelectedItem.ToString(), // Cinsiyet bilgisi eklendi
				CustomerAge = int.Parse(txtCustomerAge.Text) // Yaş bilgisi eklendi
			};

			_context.Reservations.Add(reservation);
			_context.SaveChanges();
			LoadReservations();
		}

		private string GetSeatStatusJson()
		{
			var seatStatus = new Dictionary<string, string>();
			foreach (Control control in panelSeats.Controls)
			{
				if (control is Button btnSeat)
				{
					string seatNumber = btnSeat.Text;
					string status = btnSeat.BackColor == Color.Green ? "Available" : "Sold";
					seatStatus[seatNumber] = status;
				}
			}
			return JsonConvert.SerializeObject(seatStatus);
		}

		private string GetSelectedSeat()
		{
			foreach (Control control in panelSeats.Controls)
			{
				if (control is Button btnSeat && btnSeat.BackColor == Color.Red)
				{
					return btnSeat.Text;
				}
			}
			return null;
		}

		private void dataGridViewSeats_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
			{
				var cell = dataGridViewSeats.Rows[e.RowIndex].Cells[e.ColumnIndex];
				if (cell.Style.BackColor == Color.Green)
				{
					cell.Style.BackColor = Color.Red;
					// Müşteri bilgilerini gösterme işlemi
					txtCustomerName.Text = "Yeni Müşteri Adı";
					txtCustomerSurname.Text = "Yeni Müşteri Soyadı";
					txtCustomerPhone.Text = "Yeni Müşteri Telefon";
					txtCustomerEmail.Text = "Yeni Müşteri Email";
				}
				else if (cell.Style.BackColor == Color.Red)
				{
					cell.Style.BackColor = Color.Green;
					// Müşteri bilgilerini temizleme işlemi
					txtCustomerName.Text = "";
					txtCustomerSurname.Text = "";
					txtCustomerPhone.Text = "";
					txtCustomerEmail.Text = "";
				}
			}
		}

		private void dataGridViewSeats_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			// Metod içeriği burada olacak
		}

		private void comboBoxAircrafts_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadSeats();
		}

		private void comboBoxDeparture_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (_isUpdating) return;
			_isUpdating = true;

			if (comboBoxDeparture.SelectedValue != null && comboBoxDeparture.SelectedValue.Equals(comboBoxArrival.SelectedValue))
			{
				MessageBox.Show("Departure ve Arrival aynı olamaz.");
				comboBoxDeparture.SelectedIndex = -1;
			}

			_isUpdating = false;
		}

		private void comboBoxArrival_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (_isUpdating) return;
			_isUpdating = true;

			if (comboBoxArrival.SelectedValue != null && comboBoxArrival.SelectedValue.Equals(comboBoxDeparture.SelectedValue))
			{
				MessageBox.Show("Departure ve Arrival aynı olamaz.");
				comboBoxArrival.SelectedIndex = -1;
			}

			_isUpdating = false;
		}

		private void BtnSeat_Click(object sender, EventArgs e)
		{
			Button btnSeat = sender as Button;
			if (btnSeat.BackColor == Color.Green)
			{
				btnSeat.BackColor = Color.Red;
				// Müşteri bilgilerini gösterme işlemi
				txtCustomerName.Text = "Yeni Müşteri Adı";
				txtCustomerSurname.Text = "Yeni Müşteri Soyadı";
				txtCustomerPhone.Text = "Yeni Müşteri Telefon";
				txtCustomerEmail.Text = "Yeni Müşteri Email";
			}
			else if (btnSeat.BackColor == Color.Red)
			{
				btnSeat.BackColor = Color.Green;
				// Müşteri bilgilerini temizleme işlemi
				txtCustomerName.Text = "";
				txtCustomerSurname.Text = "";
				txtCustomerPhone.Text = "";
				txtCustomerEmail.Text = "";
			}
		}

		private void panelSeats_Paint(object sender, PaintEventArgs e)
		{

		}
	}

}
