using log4net;
using System.Web.Mvc;

namespace Core.Logging
{
    public class ExceptionLoggingFilter : ExceptionLoggingFilter.IExceptionFilter
    {
        private readonly ILog _logger;

        public ExceptionLoggingFilter(ILog logger)
        {
            _logger = logger;
        }

        public virtual void OnException(ExceptionContext filterContext)
        {
            //Log Exception e
            _logger.Error(filterContext.Exception);
            filterContext.ExceptionHandled = true;
            filterContext.Result = new ViewResult()
            {
                ViewName = "Error500"
            };
        }

        public interface IExceptionFilter
        {
            void OnException(ExceptionContext filterContext);
        }
    }
}