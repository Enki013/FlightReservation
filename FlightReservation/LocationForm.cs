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


	public partial class LocationForm : Form
	{
		private ApplicationDbContext _context;

		public LocationForm()
		{
			InitializeComponent();
			_context = new ApplicationDbContext();
			LoadLocations();
		}

		private void LoadLocations()
		{
			var locations = _context.Locations.ToList();
			dataGridViewLocations.DataSource = locations;
		}

		private void btnAddLocation_Click(object sender, EventArgs e)
		{
			var location = new Location
			{
				Country = txtCountry.Text,
				City = txtCity.Text,
				Airport = txtAirport.Text,
				IsActive = chkIsActive.Checked
			};

			_context.Locations.Add(location);
			_context.SaveChanges();
			LoadLocations();
		}

		// Diğer event handler'lar ve işlevler...
	}

}


