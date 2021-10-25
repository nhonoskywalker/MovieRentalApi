using Microsoft.AspNetCore.Mvc.Filters;
using MRAPP.Services.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRentalApi.Filters
{
	public class TestActionAttribute: ActionFilterAttribute
	{
		public override void OnActionExecuted(ActionExecutedContext context)
		{
			Console.WriteLine("OnActionExecuted");
			base.OnActionExecuted(context);	
		}

		public override void OnActionExecuting(ActionExecutingContext context)
		{
			Console.WriteLine("OnActionExecuting");
			base.OnActionExecuting(context);	
		}

		public override void OnResultExecuting(ResultExecutingContext context)
		{
			Console.WriteLine("OnResultExecuting");
			base.OnResultExecuting(context);
		}

		public override void OnResultExecuted(ResultExecutedContext context)
		{
			Console.WriteLine("OnResultExecuted");
			base.OnResultExecuted(context);
		}
	}
}
