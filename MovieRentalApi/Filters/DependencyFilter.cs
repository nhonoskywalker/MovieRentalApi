using Microsoft.AspNetCore.Mvc.Filters;
using MRAPP.Services.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRentalApi.Filters
{
	public class DependencyFilter : IActionFilter
	{
		private readonly IMovieService movieService;
		public DependencyFilter(IMovieService movieService)
		{
			this.movieService = movieService;
		}

		public void OnActionExecuted(ActionExecutedContext context)
		{
			if(movieService == null)
			{
				Console.WriteLine("Depency not working");
			}
			else
			{
				Console.WriteLine("Depency works");
			}
		}

		public void OnActionExecuting(ActionExecutingContext context)
		{
			//throw new NotImplementedException();
		}
	}
}
