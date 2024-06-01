using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gift_Store_And_Inventory.Data
{
	[Table("Locations")]
	public class Location
	{
        [Key]
        public string Id { get; set; }
		[Required]
		public User CreatedBy { get; set; }
        [Required]
        public string Name { get; set; }
		[Required]
		public DateOnly CreatedAt { get; set; }

		public List<Location>? Locations { get; set; }
    }
}
