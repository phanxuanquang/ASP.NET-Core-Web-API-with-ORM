using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core_Web_API_with_Entity_Framework.Filters
{
    /// <summary>
    /// Restruct the API response to avoid exception when calling the API
    /// Appling this filter leads to the change for you API responses.
    /// </summary>
    public class ApiResponseFormatAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Result is ObjectResult result)
            {
                bool isSuccess = context.HttpContext.Response.StatusCode >= 200 && context.HttpContext.Response.StatusCode < 300;

                var failedReason = isSuccess ? null : GetExceptionMessage(context.Exception);
                var responseData = isSuccess ? result.Value : null;

                var apiResponse = new
                {
                    responseData = responseData,
                    isSuccess = isSuccess,
                    failedReason = failedReason
                };

                context.Result = new ObjectResult(apiResponse)
                {
                    StatusCode = context.HttpContext.Response.StatusCode
                };
            }
        }

        private string GetExceptionMessage(Exception ex)
        {
            if (ex == null)
            {
                return null;
            }

            var message = ex.Message;

            if (ex.InnerException != null)
            {
                message += " Inner Exception: " + GetExceptionMessage(ex.InnerException);
            }

            return message;
        }
    }
}
