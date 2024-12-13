using Services.Contracts;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Mvc.Filters;
using Entities.LogModel;

namespace Presentation.ActionFilters
{
    public class LogFilterAttribute : ActionFilterAttribute
    {
        private readonly ILoggerService _logger;

        public LogFilterAttribute(ILoggerService logger)
        {
            _logger = logger;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogInfo(Log("OnActionExecuting", context.RouteData));
        }

        private string Log(string modelName, RouteData routeData)
            {
                var logDetils = new LogDetails()
                {
                    ModelModel = modelName,
                    Controller = routeData.Values["controller"],
                    Action = routeData.Values["action"]
                };
            if (routeData.Values.Count >= 3)
                logDetils.Id = routeData.Values["Id"];
            return logDetils.ToString();
            }
    }
}
