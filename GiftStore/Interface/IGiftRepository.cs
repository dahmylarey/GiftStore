using Gift_Store_And_Inventory.Data;
using System.Threading.Tasks;

namespace GiftStore.Interface
{
	public interface IGiftIRepository
	{
		//Items Task
		Task<ICollection<Item>> GetAllItems();
		Task <Item> GetById(string id);
		Task Add(Item Model);
		Task Update(Item Model);
		Task Delete(Item Model);
		Task DeleteByid(string id);


		//Locations Task
		Task<IEnumerable<Location>> GetAllLocations();
		Task <Location> GetByName(string Name);
		Task Add(Location Model);
		Task Update(Location Model);
		Task Remove(Location Model);
		Task RemoveByid(string id);
		
		

		//Orders Tasks
		Task<IEnumerable<Order>> GetAllOrders();
		

		Task Add(Order Model);
		Task Update(Order Model);
		Task Trash(Order Model);
		Task TrashByid(string id);
		Task Delete(Location location);
	}
}
