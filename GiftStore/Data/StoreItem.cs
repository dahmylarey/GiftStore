using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gift_Store_And_Inventory.Data
{
	[Table("Store Items")]
	public class StoreItem
	{
        [Key]
        public string Id { get; set; }
		[Required]
		public double ItemId { get; set; }
        [Required]
        public double Quantity { get; set; }
		[Required]
		public DateOnly CreatedAt { get; set; }
		[Required]
		public DateOnly UpdatedAt { get;set; }
        [Required]
        public User AddedBy { get; set; }

		public ICollection<StoreItem>? StoreItems { get; set; }
		
    }
}
