namespace FlightReservation
{
	partial class MainForm
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
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageAircraft = new System.Windows.Forms.TabPage();
			this.tabPageLocation = new System.Windows.Forms.TabPage();
			this.tabPageReservation = new System.Windows.Forms.TabPage();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPageAircraft);
			this.tabControl.Controls.Add(this.tabPageLocation);
			this.tabControl.Controls.Add(this.tabPageReservation);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(800, 450);
			this.tabControl.TabIndex = 0;
			// 
			// tabPageAircraft
			// 
			this.tabPageAircraft.Location = new System.Drawing.Point(4, 24);
			this.tabPageAircraft.Name = "tabPageAircraft";
			this.tabPageAircraft.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageAircraft.Size = new System.Drawing.Size(792, 422);
			this.tabPageAircraft.TabIndex = 0;
			this.tabPageAircraft.Text = "Aircraft";
			this.tabPageAircraft.UseVisualStyleBackColor = true;
			// 
			// tabPageLocation
			// 
			this.tabPageLocation.Location = new System.Drawing.Point(4, 24);
			this.tabPageLocation.Name = "tabPageLocation";
			this.tabPageLocation.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageLocation.Size = new System.Drawing.Size(792, 422);
			this.tabPageLocation.TabIndex = 1;
			this.tabPageLocation.Text = "Location";
			this.tabPageLocation.UseVisualStyleBackColor = true;
			// 
			// tabPageReservation
			// 
			this.tabPageReservation.Location = new System.Drawing.Point(4, 24);
			this.tabPageReservation.Name = "tabPageReservation";
			this.tabPageReservation.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageReservation.Size = new System.Drawing.Size(792, 422);
			this.tabPageReservation.TabIndex = 2;
			this.tabPageReservation.Text = "Reservation";
			this.tabPageReservation.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl);
			this.Name = "MainForm";
			this.Text = "Main Form";
			this.Load += new System.EventHandler(this.MainForm_Load); // Load event added here
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageAircraft;
		private System.Windows.Forms.TabPage tabPageLocation;
		private System.Windows.Forms.TabPage tabPageReservation;
	}
}
