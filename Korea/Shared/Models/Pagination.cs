
using System.Collections.Generic;

namespace Korea.Shared.Models
{
	public class Pagination
	{
		public int Page { get; set; } = 1;
		public int Take { get; set; } = 1;
	}	

	public class Result<T>
	{
		public List<T> Data {get; set;} = new List<T>();
		public int Total { get; set; }
	}
}