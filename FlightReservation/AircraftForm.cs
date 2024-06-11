using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightReservation
{
	public partial class AircraftForm : Form
	{
		private ApplicationDbContext _context;

		public AircraftForm()
		{
			InitializeComponent();
			_context = new ApplicationDbContext();
			LoadAircrafts();
		}

		private void LoadAircrafts()
		{
			var aircrafts = _context.Aircrafts.ToList();
			dataGridViewAircrafts.DataSource = aircrafts;
		}

		private void btnAddAircraft_Click(object sender, EventArgs e)
		{
			var aircraft = new Aircraft
			{
				Model = txtModel.Text,
				Brand = txtBrand.Text,
				SerialNumber = txtSerialNumber.Text,
				SeatCapacity = int.Parse(txtSeatCapacity.Text)
			};

			_context.Aircrafts.Add(aircraft);
			_context.SaveChanges();
			LoadAircrafts();
		}

		private void AircraftForm_Load(object sender, EventArgs e)
		{

		}

		// Diğer event handler'lar ve işlevler...
	}

}
