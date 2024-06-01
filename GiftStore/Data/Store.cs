using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gift_Store_And_Inventory.Data
{
	[Table("Store")]
	public class Store
	{
        [Key]
        public string Id { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public string Location { get; set; }
		[Required]
		public DateOnly CreatedAt { get; set; }
		[Required]
		public DateOnly UpdatedAt { get; set; }
        [Required]
        public User AddedBy { get; set; }

		public ICollection<Store>? Stores { get; set; }

    }
}
