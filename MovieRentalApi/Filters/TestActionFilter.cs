namespace MovieRentalApi.Filters
{
	using Microsoft.AspNetCore.Mvc.Filters;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Threading.Tasks;

	public class TestActionFilter : IActionFilter
	{
		public void OnActionExecuted(ActionExecutedContext context)
		{
			Console.WriteLine("Executed");
		}

		public void OnActionExecuting(ActionExecutingContext context)
		{
			Console.WriteLine("Executing");
		}
	}

	public class TestAuthorizatioFilter : IAuthorizationFilter
	{
		public void OnAuthorization(AuthorizationFilterContext context)
		{
			Console.WriteLine("Authorization");
		}
	}

	public class ResourceFilter : IResourceFilter
	{
		public void OnResourceExecuted(ResourceExecutedContext context)
		{
			var x = context.HttpContext.Response.Body;
				
			Console.WriteLine("Resource executed");
			Console.WriteLine(x);

		}

		public void OnResourceExecuting(ResourceExecutingContext context)
		{
			var x = context.HttpContext.Request.Body;
			Console
				.WriteLine("Resource executing");
			Console.WriteLine(x);
		}
	}
}
