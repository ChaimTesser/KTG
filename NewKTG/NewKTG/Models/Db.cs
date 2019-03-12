namespace KTG.Models
{
	using KTG.Areas.Setup.Models;
	using System;
	using System.Data.Entity;
	using System.Linq;

	public class Db : DbContext
	{
		
		public Db() : base("name=Db") { }
		public DbSet<Cities> Cities { get; set; }
		public DbSet<Activity> Activities { get; set; }
		public DbSet<Hotel> Hotels { get; set; }
		public DbSet<Shul> Shuls { get; set; }
		public DbSet<Zman> Zmanim { get; set; }
		public DbSet<Hechsher> Hechshers { get; set; }
		public DbSet<FoodEstablishment> FoodEstablishments { get; set; }

	}

}