using Gift_Store_And_Inventory.Data;

namespace GiftStore.Interface
{
	public interface IOrderItemsRepository
	{
		//CartItem
		Task<ICollection<CartItem>> AllCartItems();
		Task<CartItem> GetById(string id);
		Task Add(CartItem Model);
		Task Update(CartItem Model);
		Task Delete(CartItem Model);
		Task DeleteByid(string id);


		//User Tasks
		Task<ICollection<User>> GetAllUsers();
		Task<User> ById(string id);
		Task Add(User Model);
		Task Update(User Model);
		Task Delete(User Model);
		Task DeleteThroughId(string id);



		//OrderItems Task 
		Task<List<OrderItem>> ListOfOrderItem();
		Task<OrderItem> GetByName(string Name);
		Task Add(OrderItem Model);
		Task Update(OrderItem Model);
		Task Remove(OrderItem Model);
		Task RemoveByid(string id);


		//StoreItems Tasks
		Task<ICollection<StoreItem>> AllStoreItems();

		
		Task Add(StoreItem Model);
		Task Update(StoreItem Model);
		Task Trash(StoreItem Model);
		Task TrashByid(string id);


	}
}
