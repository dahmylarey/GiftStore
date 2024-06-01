using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gift_Store_And_Inventory.Data
{
	[Table("Items")]
	public class Item
	{
        [Key]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public Array Image { get; set; }
        [Required]
        public  double ReorderAt { get; set; }
        [Required]
        public double MinimumOrderQuantity { get; set; }
        public string PreferredVendor { get; set; }
        [Required]
        public DateOnly CreatedAt { get; set; }
        [Required]
        public DateOnly UpdateAt { get; set; }
        [Required]
        public User CreatedBy { get; set; }

        public ICollection <Item> ?Items { get; set; }
        public virtual User? Users { get; set; }

    }
}
