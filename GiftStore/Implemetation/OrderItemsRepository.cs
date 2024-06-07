using Gift_Store_And_Inventory.Data;
using GiftStore.Data;
using GiftStore.Interface;
using Microsoft.EntityFrameworkCore;

namespace GiftStore.Implemetation
{
	public class OrderItemsRepository(ApplicationDbContext context) : IOrderItemsRepository
	{

		private readonly ApplicationDbContext _context = context;

		//CartItems
		public async Task<ICollection<CartItem>> AllCartItems()
		{
			var data = await _context.CartItems.ToListAsync();
			return data;
		}
		public async Task<CartItem> GetById(string id)
		{
			var data = await context.CartItems.FindAsync(id);
			return data;
		}
		public async Task Add(CartItem Model)
		{
			await _context.AddAsync(Model);
			_context.SaveChanges();
		}
		public async Task Update(CartItem Model)
		{
			await _context.CartItems.FindAsync(Model.Id);

			if (Model != null)
			{
				Model.Id = Model.Id;
				Model.CartId = Model.CartId;
				Model.Quantity = Model.Quantity;
				Model.ItemId = Model.ItemId;
				


				_context.CartItems.Update(Model);

				await _context.SaveChangesAsync();
			}
		}

		public Task Delete(CartItem Model)
		{
			_context.Remove(Model);
			_context.SaveChanges();
			return Task.CompletedTask;
		}
		public async Task DeleteByid(string id)
		{

			var data = await _context.CartItems.FindAsync(id);
			_context.SaveChangesAsync();

		}


		//user
		public async Task<ICollection<User>> GetAllUsers()
		{
			var data = await _context.Users.ToListAsync();
			return (ICollection<User>)data;
		}

		public async Task <User> ById(string id)
		{
			var data = await context.Users.FindAsync(id);

			throw new NotImplementedException();
			//return data;
		}
		public async Task Add(User Model)
		{
			await _context.AddAsync(Model);
			_context.SaveChanges();
		}
		public async Task Update(User model)
		{
			await _context.Users.FindAsync(model.Id);

			if (model != null)
			{
				model.Id = model.Id;
				model.Name = model.Name;
				model.DisplayName = model.DisplayName;
				model.ProfileUrl = model.ProfileUrl;

				//_context.Users.Update(model);
				await _context.SaveChangesAsync();
			}
			
		}
		public Task Delete(User Model)
		{
			_context.Remove(Model);
			_context.SaveChanges();
			return Task.CompletedTask;
		}
		public async Task DeleteThroughId(string id)
		{
			var data = await _context.Users.FindAsync(id);
			_context.SaveChangesAsync();
		}



		//OrderItem
		public async Task<List<OrderItem>> ListOfOrderItem()
		{
			var data = await _context.OrderItems.ToListAsync();
			return data;
		}
		public async Task<OrderItem> GetByName(string Name)
		{
			var data = await context.OrderItems.FindAsync(Name);
			return data;
		}
		public async Task Add(OrderItem Model)
		{
			await _context.AddAsync(Model);
			_context.SaveChanges();
		}
		public async Task Update(OrderItem Model)
		{
			await _context.OrderItems.FindAsync(Model.Id);

			if (Model != null)
			{
				Model.Id = Model.Id;
				Model.ItemId = Model.ItemId;
				Model.QuantityRequested = Model.QuantityRequested;
				Model.QuantityApprove = Model.QuantityApprove;
				Model.OrderId = Model.OrderId;


				_context.OrderItems.Update(Model);
				await _context.SaveChangesAsync();
			}

		}

		public async Task Remove(OrderItem Model)
		{
			_context.Remove(Model);
			_context.SaveChanges();
			
		}
		public async Task RemoveByid(string id)
		{
			var data = await _context.OrderItems.FindAsync(id);
			_context.SaveChangesAsync();
		}





		//StoreItems

		public async Task<ICollection<StoreItem>> AllStoreItems()
		{
			var data = await _context.StoreItems.ToListAsync();
			return data;
		}
		public async Task Add(StoreItem Model)
		{
			await _context.AddAsync(Model);
			_context.SaveChanges();
		}
		public async Task Update(StoreItem Model)
		{
			await _context.StoreItems.FindAsync(Model.Id);

			if (Model != null)
			{
				Model.Id = Model.Id;
				Model.ItemId = Model.ItemId;
				Model.Quantity = Model.Quantity;
				Model.CreatedAt = Model.CreatedAt;
				Model.UpdatedAt = Model.UpdatedAt;
				Model.AddedBy = Model.AddedBy;



				_context.StoreItems.Update(Model);

				await _context.SaveChangesAsync();
			}
		}
		public async Task Trash(StoreItem Model)
		{
			_context.Remove(Model);
			_context.SaveChanges();
			
		}


		public async Task TrashByid(string id)
		{
			var data = await _context.StoreItems.FindAsync(id);
			_context.SaveChangesAsync();
		}

	}
}
