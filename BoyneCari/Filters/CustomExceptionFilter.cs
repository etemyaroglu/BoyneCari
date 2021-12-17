using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;
namespace BoyneCari.Filters
{
    public class CustomExceptionFilter : ExceptionFilterAttribute
    {  
        public CustomExceptionFilter()
        {
      
        }
        public override void OnException(ExceptionContext context)
        {  
            context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            context.Result = new JsonResult("Bir Hata Meydana Geldi!", "500");
        }
    }
}
