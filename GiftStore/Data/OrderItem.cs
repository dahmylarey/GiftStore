using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gift_Store_And_Inventory.Data
{
	[Table("Order Items")]
	public class OrderItem
	{
        [Key]
        public string Id { get; set; }
		[Required]
		public string ItemId { get; set; }
		[Required]
		public string QuantityRequested { get; set; }
		[Required]
		public string QuantityApprove { get; set; }
		[Required]
		public string OrderId { get; set; }

	}
}
