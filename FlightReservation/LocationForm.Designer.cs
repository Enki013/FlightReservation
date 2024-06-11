namespace FlightReservation
{
	partial class LocationForm
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.dataGridViewLocations = new System.Windows.Forms.DataGridView();
			this.txtCountry = new System.Windows.Forms.TextBox();
			this.txtCity = new System.Windows.Forms.TextBox();
			this.txtAirport = new System.Windows.Forms.TextBox();
			this.chkIsActive = new System.Windows.Forms.CheckBox();
			this.btnAddLocation = new System.Windows.Forms.Button();
			this.lblCountry = new System.Windows.Forms.Label();
			this.lblCity = new System.Windows.Forms.Label();
			this.lblAirport = new System.Windows.Forms.Label();
			this.lblIsActive = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocations)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewLocations
			// 
			this.dataGridViewLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewLocations.Location = new System.Drawing.Point(12, 12);
			this.dataGridViewLocations.Name = "dataGridViewLocations";
			this.dataGridViewLocations.Size = new System.Drawing.Size(776, 286);
			this.dataGridViewLocations.TabIndex = 0;
			// 
			// txtCountry
			// 
			this.txtCountry.Location = new System.Drawing.Point(100, 320);
			this.txtCountry.Name = "txtCountry";
			this.txtCountry.Size = new System.Drawing.Size(200, 20);
			this.txtCountry.TabIndex = 1;
			// 
			// txtCity
			// 
			this.txtCity.Location = new System.Drawing.Point(100, 360);
			this.txtCity.Name = "txtCity";
			this.txtCity.Size = new System.Drawing.Size(200, 20);
			this.txtCity.TabIndex = 2;
			// 
			// txtAirport
			// 
			this.txtAirport.Location = new System.Drawing.Point(100, 400);
			this.txtAirport.Name = "txtAirport";
			this.txtAirport.Size = new System.Drawing.Size(200, 20);
			this.txtAirport.TabIndex = 3;
			// 
			// chkIsActive
			// 
			this.chkIsActive.AutoSize = true;
			this.chkIsActive.Location = new System.Drawing.Point(100, 440);
			this.chkIsActive.Name = "chkIsActive";
			this.chkIsActive.Size = new System.Drawing.Size(64, 17);
			this.chkIsActive.TabIndex = 4;
			this.chkIsActive.Text = "Is Active";
			this.chkIsActive.UseVisualStyleBackColor = true;
			// 
			// btnAddLocation
			// 
			this.btnAddLocation.Location = new System.Drawing.Point(320, 320);
			this.btnAddLocation.Name = "btnAddLocation";
			this.btnAddLocation.Size = new System.Drawing.Size(100, 140);
			this.btnAddLocation.TabIndex = 5;
			this.btnAddLocation.Text = "Add Location";
			this.btnAddLocation.UseVisualStyleBackColor = true;
			this.btnAddLocation.Click += new System.EventHandler(this.btnAddLocation_Click);
			// 
			// lblCountry
			// 
			this.lblCountry.AutoSize = true;
			this.lblCountry.Location = new System.Drawing.Point(20, 320);
			this.lblCountry.Name = "lblCountry";
			this.lblCountry.Size = new System.Drawing.Size(43, 13);
			this.lblCountry.TabIndex = 6;
			this.lblCountry.Text = "Country";
			// 
			// lblCity
			// 
			this.lblCity.AutoSize = true;
			this.lblCity.Location = new System.Drawing.Point(20, 360);
			this.lblCity.Name = "lblCity";
			this.lblCity.Size = new System.Drawing.Size(24, 13);
			this.lblCity.TabIndex = 7;
			this.lblCity.Text = "City";
			// 
			// lblAirport
			// 
			this.lblAirport.AutoSize = true;
			this.lblAirport.Location = new System.Drawing.Point(20, 400);
			this.lblAirport.Name = "lblAirport";
			this.lblAirport.Size = new System.Drawing.Size(40, 13);
			this.lblAirport.TabIndex = 8;
			this.lblAirport.Text = "Airport";
			// 
			// lblIsActive
			// 
			this.lblIsActive.AutoSize = true;
			this.lblIsActive.Location = new System.Drawing.Point(20, 440);
			this.lblIsActive.Name = "lblIsActive";
			this.lblIsActive.Size = new System.Drawing.Size(47, 13);
			this.lblIsActive.TabIndex = 9;
			this.lblIsActive.Text = "Is Active";
			// 
			// LocationForm
			// 
			this.ClientSize = new System.Drawing.Size(800, 480);
			this.Controls.Add(this.lblIsActive);
			this.Controls.Add(this.lblAirport);
			this.Controls.Add(this.lblCity);
			this.Controls.Add(this.lblCountry);
			this.Controls.Add(this.btnAddLocation);
			this.Controls.Add(this.chkIsActive);
			this.Controls.Add(this.txtAirport);
			this.Controls.Add(this.txtCity);
			this.Controls.Add(this.txtCountry);
			this.Controls.Add(this.dataGridViewLocations);
			this.Name = "LocationForm";
			this.Text = "Location Form";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocations)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private System.Windows.Forms.DataGridView dataGridViewLocations;
		private System.Windows.Forms.TextBox txtCountry;
		private System.Windows.Forms.TextBox txtCity;
		private System.Windows.Forms.TextBox txtAirport;
		private System.Windows.Forms.CheckBox chkIsActive;
		private System.Windows.Forms.Button btnAddLocation;
		private System.Windows.Forms.Label lblCountry;
		private System.Windows.Forms.Label lblCity;
		private System.Windows.Forms.Label lblAirport;
		private System.Windows.Forms.Label lblIsActive;
	}

}