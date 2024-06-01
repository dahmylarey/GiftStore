using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gift_Store_And_Inventory.Data
{
	[Table("Order")]
	public class Order
	{
		[Key]
        public string Id { get; set; }
		[Required]
		public string UserId { get; set; }

		[Required]
		public Array OrderItems { get; set; }
        [Required]
        public DateOnly DateCreated { get; set; }
		[Required]
		public string Status { get; set; }
		[Required]
		public string Comment { get; set; }

		public ICollection<Order>? Orders { get; set; }
		

	}
}
