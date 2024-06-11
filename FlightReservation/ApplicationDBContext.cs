using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.IO;

namespace FlightReservation
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<Aircraft> Aircrafts { get; set; }
		public DbSet<Location> Locations { get; set; }
		public DbSet<Reservation> Reservations { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//build database
			optionsBuilder.UseSqlite("Data Source=reservation.db");

			string dbPath = "reservation.db";
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlite($"Data Source={dbPath}");
			}

			// Check if the database file exists
			if (!File.Exists(dbPath))
			{
				throw new FileNotFoundException($"The database file '{dbPath}' does not exist.");
			}

			// Ensure the application has permission to access the database file
			FileInfo fileInfo = new FileInfo(dbPath);
			if (!fileInfo.Exists || fileInfo.IsReadOnly)
			{
				throw new UnauthorizedAccessException($"The database file '{dbPath}' is not accessible or is read-only.");
			}
		}



	}

}