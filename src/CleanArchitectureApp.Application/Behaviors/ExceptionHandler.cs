using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Wahio.Apis.ClientApi.Application.Behaviors
{
    public class ExceptionHandler
    {
        public static IActionResult HandleException(Exception ex, ILogger log)
        {
            if (ex is ValidationException validationEx)
            {
                log.LogError($"Validation error: {validationEx.Message}", validationEx);
                return new BadRequestObjectResult(validationEx.Errors);
            }
            else
            {
                log.LogError($"An unexpected error occurred: {ex.Message}", ex);
                return new BadRequestObjectResult(ex.Message);
            }
        }
    }
}
