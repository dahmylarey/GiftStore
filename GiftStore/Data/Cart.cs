using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gift_Store_And_Inventory.Data
{
	[Table("Carts")]
	public class Cart
	{
        [Key]
        public string Id { get; set; }
		[Required]
		public Array CartItems { get; set; }
		[Required]
		public DateOnly DateCreated { get; set; }
		[Required]
		public string UserId { get; set; }

		public ICollection<Cart> Carts { get; set; }
	}
}
