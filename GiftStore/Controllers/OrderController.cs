using Gift_Store_And_Inventory.Data;
using GiftStore.Data;
using GiftStore.Interface;
using Microsoft.AspNetCore.Mvc;

namespace GiftStore.Controllers
{
	public class OrderController : Controller
	{

		private readonly ApplicationDbContext _context;

		public OrderController(ApplicationDbContext context)
		{
			_context = context;
		}

		private readonly IGiftIRepository giftRepo;

		public OrderController(IGiftIRepository giftRepo)
		{
			this.giftRepo = giftRepo;
		}

		//load All Order
		public async Task<IActionResult> Index()
		{
			var data = await this.giftRepo.GetAllOrders();
			return View(data);
		}

		//load single Order
		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(string id)
		{
			var data = await _context.Orders.FindAsync();
			return View(data);
		}

		//Upload Order
		[HttpPost]
		public async Task<IActionResult> Create()
		{
			var data = await this.giftRepo.GetAllOrders();
			return View(data);
		}

		//Update
		[HttpPut]
		public async Task<IActionResult> Update(Order Model)
		{
			var data = await _context.Orders.FindAsync(Model.Id);
			return View(data);
		}

		//Delete
		[HttpPost]
		public async Task<IActionResult> Trash(Order Model)
		{
			try
			{
				await giftRepo.Trash(Model);
				TempData["SuccesMessage"] = "The Order removed successfully";
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
		public async Task<IActionResult> TrashByid(string id)
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

			TempData["errorMessage"] = $"Order not found with the Id: {id}";
			return RedirectToAction("Index");
		}
	}
}
