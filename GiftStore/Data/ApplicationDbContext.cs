using Gift_Store_And_Inventory.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace GiftStore.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		public DbSet<Item> Users { get; set; }

		public DbSet<Item> Items { get; set; }
		public DbSet<Cart> Carts { get; set; } 
		public DbSet<CartItem> CartItems { get; set; }
		public DbSet<Store> stores { get; set; }
		public DbSet<Location> Locations { get; set; } 
		public DbSet<Order> Orders { get; set; } 
		public DbSet<OrderItem> OrderItems { get; set; }
		public DbSet<Restock> Restocks { get; set; }
		public DbSet<Store> Stores { get; set; }
		public DbSet<StoreItem> StoreItems { get; set; }



		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
		//builder.Entity<User>().HasNoKey();
			
		}
	}


}
