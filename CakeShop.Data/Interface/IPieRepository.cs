using System.Collections.Generic;

namespace CakeShop.Data.Entites
{
	public interface IPieRepository
	{
		IEnumerable<Pie> AllPies { get; }
		IEnumerable<Pie> PiesOfTheWeek { get; }
		Pie GetPieById(int pieId);
	}
}
