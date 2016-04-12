using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace EnumerableHttpClientFails.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
		[HttpGet("rangefails")]
		public IActionResult TestArrayFails()
		{
			return Json(GetTestRange());
		}

		[HttpGet("rangetolist")]
		public IActionResult TestArrayToList()
		{
			return Json(GetTestRange().ToList());
		}

		[HttpGet("rangecount")]
		public IActionResult TestArrayCount()
		{
			var range = GetTestRange();
			var count = range.Count();
			return Json(range);
		}


		private IEnumerable<string> GetTestRange()
		{
			return Enumerable.Range(1, 1000).Select(n => "0123456789");
		}
	}
}
