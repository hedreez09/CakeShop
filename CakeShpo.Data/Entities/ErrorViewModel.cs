using System;

namespace CakeShop.Data.Entites
{
	public class ErrorViewModel1
	{
		public string RequestId { get; set; }

		public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
	}
}
