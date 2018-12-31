namespace KTG.Models
{
	using System;
	using System.Data.Entity;
	using System.Linq;

	public class KTGDb : DbContext
	{
		public KTGDb() : base("name=DefaultConnection") { }
		public virtual DbSet<Cities> Cities { get; set; }
	}

}