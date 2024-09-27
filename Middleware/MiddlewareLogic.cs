namespace lr_one.Middleware
{
    public class MiddlewareLogic
    {
        private readonly RequestDelegate next;

        public MiddlewareLogic(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var path = context.Request.Path;
            if (path == "/ex1")
            {
                if (context.Request.Query.Keys.Contains("name") && context.Request.Query.Keys.Contains("type") && context.Request.Query.Keys.Contains("countries") && context.Request.Query.Keys.Contains("staff"))
                {
                    Company responseCompany = new Company();
                    responseCompany.Name = context.Request.Query["name"].ToString();
                    responseCompany.Type = context.Request.Query["type"].ToString();
                    responseCompany.Countries = context.Request.Query["countries"].ToString().Split(",");
                    Int32.TryParse(context.Request.Query["staff"].ToString(), out int staff);
                    responseCompany.Staff = staff;
                    await context.Response.WriteAsync($"{responseCompany}");
                }
                else
                {
                    await context.Response.WriteAsync($"Error QueryString! Try this format: \"?name=...&type=...&countries=...&staff=...\"");
                }
            }
            else if (path == "/ex2")
            {
                Random rnd = new Random();
                int number = rnd.Next(0, 101);
                await context.Response.WriteAsync($"Your random number is {number}");
            }
            else
            {
                await next.Invoke(context);
            }
        }
    }
}
