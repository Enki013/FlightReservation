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
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			var aircraftForm = new AircraftForm();
			aircraftForm.TopLevel = false;
			aircraftForm.FormBorderStyle = FormBorderStyle.None;
			aircraftForm.Dock = DockStyle.Fill;
			this.tabPageAircraft.Controls.Add(aircraftForm);
			aircraftForm.Show();

			var locationForm = new LocationForm();
			locationForm.TopLevel = false;
			locationForm.FormBorderStyle = FormBorderStyle.None;
			locationForm.Dock = DockStyle.Fill;
			this.tabPageLocation.Controls.Add(locationForm);
			locationForm.Show();

			var reservationForm = new ReservationForm();
			reservationForm.TopLevel = false;
			reservationForm.FormBorderStyle = FormBorderStyle.None;
			reservationForm.Dock = DockStyle.Fill;
			this.tabPageReservation.Controls.Add(reservationForm);
			reservationForm.Show();
		}
	}
}
