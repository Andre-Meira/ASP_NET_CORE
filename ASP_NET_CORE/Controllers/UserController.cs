using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_NET_CORE.Models;


namespace ASP_NET_CORE.Controllers
{
	public class UserController : Controller
	{
		private readonly Contexto _contexto;

		public UserController(Contexto contexto) 
		{
			_contexto = contexto;
		}


		public IActionResult Index()
		{
			
			return View(_contexto.User.ToList());
		}


		[HttpGet]
		public IActionResult NovoUser()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult NovoUser(User user) 
		{
			if (ModelState.IsValid)
			{
				_contexto.Add(user);
				_contexto.SaveChanges();
				return RedirectToAction(nameof(Index));
			}
			return View(user);

		}

	}
}
