using CakeShop.Data.Entites;
using CakeShop.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShop.Core.Repository
{
	public class CategoryRepository:ICategoryRepository
	{
		private readonly AppDbContext _appDbContext;
		public CategoryRepository(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}
		public IEnumerable<Category> AllCategories => _appDbContext.Categories;
	}
}
