using Gift_Store_And_Inventory.Data;
using GiftStore.Data;
using GiftStore.Interface;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NuGet.Protocol.Plugins;
using System.Runtime.CompilerServices;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace GiftStore.Implemetation
{
	public class GiftRepository(ApplicationDbContext context) : IGiftIRepository
	{
		private readonly ApplicationDbContext _context = context;

		//Items
		public async Task<ICollection<Item>> GetAllItems()
		{
			var data = await _context.Items.ToListAsync();
			return data;

		}
		public async Task <Item> GetById(string id)
		{
			var data = await context.Items.FindAsync(id);
			return data;
					
			
		}
		public async Task Add(Item Model)
		{
			await _context.AddAsync(Model);
			_context.SaveChanges();
		}

		public async Task Update(Item Model)
		{
			await _context.Items.FindAsync(Model.Id);

				if (Model != null)
				{
				Model.Id = Model.Id;
				Model.Name = Model.Name;
				Model.Description = Model.Description;
				Model.Image = Model.Image;
				Model.ReorderAt = Model.ReorderAt;
				Model.MinimumOrderQuantity=Model.MinimumOrderQuantity;
				Model.PreferredVendor = Model.PreferredVendor;
				Model.CreatedAt = Model.CreatedAt;
				Model.UpdateAt = Model.UpdateAt;
				Model.CreatedBy = Model.CreatedBy;

					_context.Items.Update(Model);

					await _context.SaveChangesAsync();
				}

		}
		public Task Delete(Item Model)
		{
			_context.Remove(Model);
			_context.SaveChanges();
			return Task.CompletedTask;
		}

		public async Task DeleteByid(string id)
		{
			var data = await _context.Items.FindAsync(id);
			
		}



		//Locations
		public async Task<IEnumerable<Location>> GetAllLocations()
		{
			var data = await _context.Locations.ToListAsync();
			return data;

		}
		public async Task Add(Location Model)
		{
			await _context.AddAsync(Model);
			_context.SaveChanges();
		}
		public async Task Update(Location Model)
		{
			var data = await _context.Items.FindAsync(Model.Id);

			if (data != null)
			{
				Model.Id = Model.Id;
				Model.Name = Model.Name;
				Model.CreatedBy = Model.CreatedBy;
				Model.Name = Model.Name;
				Model.CreatedAt = Model.CreatedAt;
				_context.Items.Update(data);

				await _context.SaveChangesAsync();
			}
		}
		public async Task<Location> GetByName(string Name)
		{
			var data = await _context.Locations.FindAsync(Name);
			return data;

		}
		public Task Remove(Location model)
		{
			_context.Remove(model);
			_context.SaveChanges();
			return Task.CompletedTask;
		}

		public async Task RemoveByid(string id)
		{
			var data = await _context.Items.FindAsync(id);
			if (data != null)
			{
				_context.Items.Remove(data);
				await _context.SaveChangesAsync();
			}
		}



		//Orders
		public async Task<IEnumerable<Order>> GetAllOrders()
		{
			var data = await _context.Orders.ToListAsync();
			return data;
		}
		public async Task Add(Order Model)
		{
			await _context.AddAsync(Model);
			_context.SaveChanges();
		}

		public async Task Update(Order Model)
		{

			var data = await _context.Items.FindAsync(Model.Id);

			if (Model != null)
			{
				Model.Id = Model.Id;
				Model.UserId = Model.UserId;
				Model.OrderItems = Model.OrderItems;
				Model.DateCreated = Model.DateCreated;
				Model.Status = Model.Status;
				Model.Comment = Model.Comment;
				

				_context.Items.Update(data);

				await _context.SaveChangesAsync();
			}
		}

		
		public Task Trash(Order Model)
		{
			_context.Remove(Model);
			_context.SaveChanges();
			return Task.CompletedTask;
		}

		public async Task TrashByid(string id)
		{
			var data = await _context.Orders.FindAsync(id);
			if (data != null)
			{
				_context.Orders.Remove(data);
				await _context.SaveChangesAsync();
			}
		}
			
		
		
	}
}

	
	
