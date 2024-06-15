using Gift_Store_And_Inventory.Data;
using GiftStore.Data;
using GiftStore.Interface;
using Microsoft.AspNetCore.Mvc;

namespace GiftStore.Controllers
{

	public class ItemController : Controller
	{
		private readonly ApplicationDbContext _context;
		private readonly IGiftIRepository giftRepo;
		public ItemController(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<IActionResult> Index()
		{
			var data = await this.giftRepo.GetAllItems();
			return View(data);
		}

		

		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(string id)
		{
			var data = await _context.Items.FindAsync();
			return View(data);
		}

		[HttpPost]
		public async Task<IActionResult> Create()
		{
			var data = await this.giftRepo.GetAllItems();
			return View(data);
		}

		[HttpPut]
		public async Task<IActionResult> Update(Item Model)
		{
			var data = await _context.Items.FindAsync(Model.Id);
			return View(data);
		}

		[HttpPost]
		public async Task<IActionResult> Delete(Item item) 
		{
			try
			{
				await giftRepo.Delete(item);
				TempData["SuccesMessage"] = "The Item is deleted successfully";
				_context.SaveChanges();
				RedirectToAction(nameof(Index));

			}
			catch (Exception ex)
			{


				TempData["ErrorMessage"] = ex.Message;
				return View();
			};
			return View();
		}

		[HttpGet]
		public async Task<IActionResult> Delete(string id)
		{
			var data = await giftRepo.GetById(id);
			try
			{
				if (data != null)
				{
					return View(data);
				}
			}
			catch (Exception ex)
			{

				TempData["ErrorMessage"] = ex.Message;
				return RedirectToAction("Index");
			}

			TempData["errorMessage"] = $"Item not foud with the Id: {id}";
			return RedirectToAction("Index");
		}
	}
}
