using Microsoft.AspNetCore.Mvc.Filters;

namespace MVCDemo.Filter
{
    public class MyLog : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // Do something before the action executes.
            Console.WriteLine($"- {nameof(MyLog)}.{nameof(OnActionExecuting)}");
            base.OnActionExecuting(context);
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            // Do something after the action executes.
            Console.WriteLine($"- {nameof(MyLog)}.{nameof(OnActionExecuting)}");
            base.OnActionExecuted(context);
        }
    }
}
