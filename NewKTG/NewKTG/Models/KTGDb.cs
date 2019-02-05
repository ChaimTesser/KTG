namespace KTG.Models
{
	using System;
	using System.Data.Entity;
	using System.Linq;

	public class KTGDb : DbContext
	{
		public KTGDb() : base("name=DefaultConnection") { }
		public virtual DbSet<Cities> Cities { get; set; }
		public virtual DbSet<Hotel> Hotels { get; set; }
		public virtual DbSet<FoodEstablishment> FoodEstablishments { get; set; }
		public virtual DbSet<Shul> Shuls { get; set; }
		public virtual DbSet<Zman> Zmanim { get; set; }
	}

}