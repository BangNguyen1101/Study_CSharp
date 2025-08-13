using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

public class MyAuthorizationFilter : IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        Console.WriteLine("- Authorization Filter: Checking token...");

        var token = context.HttpContext.Request.Headers["Authorization"].ToString();
        if (string.IsNullOrEmpty(token) || token != "123")
        {
            context.Result = new UnauthorizedResult();
        }
    }
}

public class MyResourceFilter : IResourceFilter
{
    public void OnResourceExecuting(ResourceExecutingContext context)
    {
        Console.WriteLine("- Resource Filter: Before resource execution");
    }

    public void OnResourceExecuted(ResourceExecutedContext context)
    {
        Console.WriteLine("- Resource Filter: After resource execution");
    }
}

public class MyActionFilter : IActionFilter
{
    public void OnActionExecuting(ActionExecutingContext context)
    {
        Console.WriteLine("- Action Filter: Before action executing");
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        Console.WriteLine("- Action Filter: After action executed");
    }
}

public class MyExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        Console.WriteLine($"- Exception Filter: {context.Exception.Message}");

        context.Result = new JsonResult(new
        {
            error = context.Exception.Message,
            time = DateTime.Now
        })
        { StatusCode = 500 };
    }
}

public class MyResultFilter : IResultFilter
{
    public void OnResultExecuting(ResultExecutingContext context)
    {
        Console.WriteLine("- Result Filter: Before result executing");
    }

    public void OnResultExecuted(ResultExecutedContext context)
    {
        Console.WriteLine("- Result Filter: After result executed");
    }
}
