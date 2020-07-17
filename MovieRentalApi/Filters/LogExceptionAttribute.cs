namespace MRAPP.Filters
{
    using MRAPP.Insfrastructure.Extensions;
    using MRAPP.Insfrastructure.Logger;
    using MRAPP.Messages;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Filters;

    public class LogExceptionAttribute : ExceptionFilterAttribute
    {
        private readonly ILogger logger;

        public LogExceptionAttribute(ILogger logger)
        {
            this.logger = logger;
        }

        public override void OnException(ExceptionContext context)
        {
            var innermost = context.Exception.GetInnermostException();
            this.logger.WriteException(innermost);

            var response = new WebResponse();
            response.Errors.Add("Unexpected error");
            context.Result = new BadRequestObjectResult(response);
        }
    }
}
