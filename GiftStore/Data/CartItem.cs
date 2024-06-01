using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gift_Store_And_Inventory.Data
{
	[Table("Cart Items")]
	public class CartItem
	{
        [Key]
        public string Id { get; set; }
		[Required]
		public string CartId { get; set; }
		[Required]
		public string Quantity { get; set; }
		[Required]
		public string ItemId { get; set; }

		public List<CartItem>? CartItems { get; set; }
	}
}
