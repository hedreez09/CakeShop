using CakeShop.Data.Entites;
using CakeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShop.ViewModels
{
	public class HomeViewModel
	{
		public IEnumerable<Pie> PiesOfTheWeek { get; set; }
	}
}
