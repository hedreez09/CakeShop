using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CakeShop.Models;
using CakeShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CakeShop.Controllers
{
	public class PieController : Controller
	{
		private readonly IPieRepository _pieRepository;
		private readonly ICategoryRepository _categoryRepository;

		public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
		{
			_pieRepository = pieRepository;
			_categoryRepository = categoryRepository;
		}

		public ViewResult List()
		{
			PiesListViewModel pieListViewModel = new PiesListViewModel();
			pieListViewModel.CurrentCategory = "Cheese Cakes";
			return View(pieListViewModel);
		}
	}
}
