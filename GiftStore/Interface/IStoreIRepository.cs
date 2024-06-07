using Gift_Store_And_Inventory.Data;

namespace GiftStore.Interface
{
	public interface IStoreIRepository
	{
		//store
		Task<ICollection<Store>> GetAllStores();
		Task <Store> GetById(string id);
		Task Add(Store Model);
		Task Update(Store Model);
		Task Delete(Store Model);
		Task DeleteByid(string id);

		//Restock 
		Task<List<Restock>> AllRestock();
		Task<Restock> GetByName(string Name);
		Task Add(Restock Model);
		Task Update(Restock Model);
		Task Remove(Restock Model);
		Task RemoveByid(string id);


		//Cart Tasks
		Task<ICollection<Cart>> GetAllOrders();
		Task Add(Cart Model);
		Task Update(Cart Model);
		Task Trash(Cart Model);
		Task TrashByid(string id);
	}
}
