using GiftStore.Interface;
using GiftStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GiftStore.Controllers
{
	public class HomeController : Controller
	{
		

		private readonly IGiftIRepository GiftRepo;

		public HomeController(IGiftIRepository giftRepo)
		{
			GiftRepo = giftRepo;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
