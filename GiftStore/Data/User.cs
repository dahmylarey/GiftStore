using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Security.Policy;

namespace Gift_Store_And_Inventory.Data
{

	public class User : IdentityUser
	{
		[Key]
        public  string Id { get; set; }
		public string Name { get; set; }
        public string DisplayName { get; set; }
		public string ProfileUrl { get; set; }

	
		public ICollection<User>?Users { get; set; }
	}
}
