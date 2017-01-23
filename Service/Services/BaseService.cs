using System.Web.Mvc;
using System.Web.Http;

namespace Service.Serivices
{
    public abstract class BaseService
    {
        public void AddError(string message, ModelStateDictionary modelState)
        {
            if (modelState != null)
            {
                modelState.AddModelError("", message);
            }
        }

        public void AddError(string message, System.Web.Http.ModelBinding.ModelStateDictionary modelState)
        {
            if (modelState != null)
            {
                modelState.AddModelError("", message);
            }
        }
    }
}