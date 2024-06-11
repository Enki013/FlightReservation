namespace FlightReservation
{
	partial class AircraftForm
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
			this.dataGridViewAircrafts = new System.Windows.Forms.DataGridView();
			this.txtModel = new System.Windows.Forms.TextBox();
			this.txtBrand = new System.Windows.Forms.TextBox();
			this.txtSerialNumber = new System.Windows.Forms.TextBox();
			this.txtSeatCapacity = new System.Windows.Forms.TextBox();
			this.btnAddAircraft = new System.Windows.Forms.Button();
			this.lblModel = new System.Windows.Forms.Label();
			this.lblBrand = new System.Windows.Forms.Label();
			this.lblSerialNumber = new System.Windows.Forms.Label();
			this.lblSeatCapacity = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAircrafts)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewAircrafts
			// 
			this.dataGridViewAircrafts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewAircrafts.Location = new System.Drawing.Point(12, 12);
			this.dataGridViewAircrafts.Name = "dataGridViewAircrafts";
			this.dataGridViewAircrafts.Size = new System.Drawing.Size(776, 286);
			this.dataGridViewAircrafts.TabIndex = 0;
			// 
			// txtModel
			// 
			this.txtModel.Location = new System.Drawing.Point(100, 320);
			this.txtModel.Name = "txtModel";
			this.txtModel.Size = new System.Drawing.Size(200, 20);
			this.txtModel.TabIndex = 1;
			// 
			// txtBrand
			// 
			this.txtBrand.Location = new System.Drawing.Point(100, 360);
			this.txtBrand.Name = "txtBrand";
			this.txtBrand.Size = new System.Drawing.Size(200, 20);
			this.txtBrand.TabIndex = 2;
			// 
			// txtSerialNumber
			// 
			this.txtSerialNumber.Location = new System.Drawing.Point(100, 400);
			this.txtSerialNumber.Name = "txtSerialNumber";
			this.txtSerialNumber.Size = new System.Drawing.Size(200, 20);
			this.txtSerialNumber.TabIndex = 3;
			// 
			// txtSeatCapacity
			// 
			this.txtSeatCapacity.Location = new System.Drawing.Point(100, 440);
			this.txtSeatCapacity.Name = "txtSeatCapacity";
			this.txtSeatCapacity.Size = new System.Drawing.Size(200, 20);
			this.txtSeatCapacity.TabIndex = 4;
			// 
			// btnAddAircraft
			// 
			this.btnAddAircraft.Location = new System.Drawing.Point(340, 320);
			this.btnAddAircraft.Name = "btnAddAircraft";
			this.btnAddAircraft.Size = new System.Drawing.Size(100, 140);
			this.btnAddAircraft.TabIndex = 5;
			this.btnAddAircraft.Text = "Add Aircraft";
			this.btnAddAircraft.UseVisualStyleBackColor = true;
			this.btnAddAircraft.Click += new System.EventHandler(this.btnAddAircraft_Click);
			// 
			// lblModel
			// 
			this.lblModel.AutoSize = true;
			this.lblModel.Location = new System.Drawing.Point(20, 320);
			this.lblModel.Name = "lblModel";
			this.lblModel.Size = new System.Drawing.Size(36, 13);
			this.lblModel.TabIndex = 6;
			this.lblModel.Text = "Model";
			// 
			// lblBrand
			// 
			this.lblBrand.AutoSize = true;
			this.lblBrand.Location = new System.Drawing.Point(20, 360);
			this.lblBrand.Name = "lblBrand";
			this.lblBrand.Size = new System.Drawing.Size(35, 13);
			this.lblBrand.TabIndex = 7;
			this.lblBrand.Text = "Brand";
			// 
			// lblSerialNumber
			// 
			this.lblSerialNumber.AutoSize = true;
			this.lblSerialNumber.Location = new System.Drawing.Point(20, 400);
			this.lblSerialNumber.Name = "lblSerialNumber";
			this.lblSerialNumber.Size = new System.Drawing.Size(73, 13);
			this.lblSerialNumber.TabIndex = 8;
			this.lblSerialNumber.Text = "Serial Number";
			// 
			// lblSeatCapacity
			// 
			this.lblSeatCapacity.AutoSize = true;
			this.lblSeatCapacity.Location = new System.Drawing.Point(20, 440);
			this.lblSeatCapacity.Name = "lblSeatCapacity";
			this.lblSeatCapacity.Size = new System.Drawing.Size(73, 13);
			this.lblSeatCapacity.TabIndex = 9;
			this.lblSeatCapacity.Text = "Seat Capacity";
			// 
			// AircraftForm
			// 
			this.ClientSize = new System.Drawing.Size(800, 480);
			this.Controls.Add(this.lblSeatCapacity);
			this.Controls.Add(this.lblSerialNumber);
			this.Controls.Add(this.lblBrand);
			this.Controls.Add(this.lblModel);
			this.Controls.Add(this.btnAddAircraft);
			this.Controls.Add(this.txtSeatCapacity);
			this.Controls.Add(this.txtSerialNumber);
			this.Controls.Add(this.txtBrand);
			this.Controls.Add(this.txtModel);
			this.Controls.Add(this.dataGridViewAircrafts);
			this.Name = "AircraftForm";
			this.Text = "Aircraft Form";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAircrafts)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private System.Windows.Forms.DataGridView dataGridViewAircrafts;
		private System.Windows.Forms.TextBox txtModel;
		private System.Windows.Forms.TextBox txtBrand;
		private System.Windows.Forms.TextBox txtSerialNumber;
		private System.Windows.Forms.TextBox txtSeatCapacity;
		private System.Windows.Forms.Button btnAddAircraft;
		private System.Windows.Forms.Label lblModel;
		private System.Windows.Forms.Label lblBrand;
		private System.Windows.Forms.Label lblSerialNumber;
		private System.Windows.Forms.Label lblSeatCapacity;
	}

}