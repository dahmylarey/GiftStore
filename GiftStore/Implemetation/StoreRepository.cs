using Gift_Store_And_Inventory.Data;
using GiftStore.Data;
using GiftStore.Interface;
using Microsoft.EntityFrameworkCore;

namespace GiftStore.Implemetation
{
	public class StoreRepository (ApplicationDbContext context) : IStoreIRepository
	{
		private readonly ApplicationDbContext _context = context;

		//Store
		public async Task<ICollection<Store>> GetAllStores()
		{
			var data = await _context.Stores.ToListAsync();
			return data;
		}

		public async Task<Store> GetById(string id)
		{
			var data = await context.Stores.FindAsync(id);
			return data;
		}

		public async Task Add(Store Model)
		{
			await _context.AddAsync(Model);
			_context.SaveChanges();
		}
		public async Task Update(Store Model)
		{
			await _context.Stores.FindAsync(Model.Id);

			if (Model != null)
			{
				Model.Id = Model.Id;
				Model.Name = Model.Name;
				Model.Location = Model.Location;
				Model.CreatedAt = Model.CreatedAt;
				Model.AddedBy = Model.AddedBy;
				

				_context.Stores.Update(Model);

				await _context.SaveChangesAsync();
			}
		}

		public Task Delete(Store Model)
		{
			_context.Remove(Model);
			_context.SaveChanges();
			return Task.CompletedTask;
		}
		public async Task DeleteByid(string id)
		{
			var data = await _context.stores.FindAsync(id);
			_context.SaveChangesAsync();

		}


		//Restock
		public async Task<List<Restock>> AllRestock()
		{
			var data = await _context.Restocks.ToListAsync();
			return data;
		}
		public async Task<Restock> GetByName(string Name)
		{
			var data = await context.Restocks.FindAsync(Name);
			return data;
		}

		public async Task Add(Restock Model)
		{
			await _context.AddAsync(Model);
			_context.SaveChanges();
		}
		public async Task Update(Restock Model)
		{
			await _context.Restocks.FindAsync(Model.Id);

			if (Model != null)
			{
				Model.Id = Model.Id;
				Model.ItemId = Model.ItemId;
				Model.StoreId = Model.StoreId;
				Model.QuantityReceived = Model.QuantityReceived;
				Model.ReceivedBy = Model.ReceivedBy;
				Model.DateReceived = Model.DateReceived;
				Model.ReferenceNumber=Model.ReferenceNumber;


				_context.Restocks.Update(Model);

				await _context.SaveChangesAsync();
			}
		}
		public Task Remove(Restock Model)
		{
			_context.Remove(Model);
			_context.SaveChanges();
			return Task.CompletedTask;
		}
		public async Task RemoveByid(string id)
		{
			var data = await _context.Restocks.FindAsync(id);
			_context.SaveChangesAsync();
		}


		//Cart Tasks
		public async Task<ICollection<Cart>> GetAllCarts()
		{
			var data = await _context.Carts.ToListAsync();
			return data;
		}

		

		public async Task Add(Cart Model)
		{
			await _context.AddAsync(Model);
			_context.SaveChanges();
		}
		public async Task Update(Cart Model)
		{
			await _context.Carts.FindAsync(Model.Id);

			if (Model != null)
			{
				Model.Id = Model.Id;
				Model.CartItems = Model.CartItems;
				Model.DateCreated = Model.DateCreated;
				Model.UserId = Model.UserId;
				


				_context.Carts.Update(Model);

				await _context.SaveChangesAsync();
			}
		}
		public async Task Trash(Cart Model)
		{
			var data = await _context.Carts.FindAsync(Model);
			_context.SaveChangesAsync();
		}
		public async Task TrashByid(string id)
		{
			var data = await _context.Carts.FindAsync(id);
			_context.SaveChangesAsync();
		}

		



		
	}
}
