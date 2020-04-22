using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShop.Models
{
	//This is implementing category Repository interface
	public class MockCategoryRepository: ICategoryRepository
	{
		public IEnumerable<Category> AllCategories => new List<Category>
		{
			new Category{CategoryId = 1, CategoryName = "Fruit Pies", Description = "All-fruity Pies"},
			new Category{CategoryId = 2, CategoryName = "Cheese Cake", Description = "Cheesy all the way"},
			new Category{CategoryId = 3, CategoryName = "Seasonal Pie", Description = "Get in all the mood for a seasonal pie."}
		};
	}
}
