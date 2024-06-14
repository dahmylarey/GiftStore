using Gift_Store_And_Inventory.Data;
using GiftStore.Data;
using GiftStore.Interface;
using Microsoft.AspNetCore.Mvc;

namespace GiftStore.Controllers
{
	public class LocationController : Controller
	{
		private readonly IGiftIRepository giftRepo;
		public LocationController(IGiftIRepository giftRepo)
		{
			this.giftRepo = giftRepo;
		}

		private readonly ApplicationDbContext _context;

		public LocationController(ApplicationDbContext context)
		{
			_context = context;
		}

		//load All Location
		public async Task<IActionResult> Index()
		{
			var data = await this.giftRepo.GetAllLocations();
			return View(data);
		}

		//Upload Location
		[HttpPost]
		public async Task<IActionResult> Create()
		{
			var data = await this.giftRepo.GetAllLocations();
			return View(data);
		}


		//Delete
		[HttpPost]
		public async Task<IActionResult> Remove(Location model)
		{
			try
			{
				await giftRepo.Delete(model);
				TempData["SuccesMessage"] = "The Location deleted successfully";
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
		public async Task<IActionResult> RemoveByid(string id)
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

			TempData["errorMessage"] = $"Location not found with the Id: {id}";
			return RedirectToAction("Index");
		}
	}
}
