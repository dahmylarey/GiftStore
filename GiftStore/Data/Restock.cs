using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gift_Store_And_Inventory.Data
{
	[Table("Restock")]
	public class Restock
	{
        [Key]
        public string Id { get; set; }
		[Required]
		public string ItemId { get; set; }
		[Required]
		public string StoreId { get; set; }
		[Required]
		public double QuantityReceived { get; set; }
        [Required]
        public User ReceivedBy { get; set; }
        [Required]
        public DateOnly DateReceived { get; set; }
        public string ReferenceNumber { get; set; }
		 
		public List <Restock> ?Restocks { get; set; }

    }
}
