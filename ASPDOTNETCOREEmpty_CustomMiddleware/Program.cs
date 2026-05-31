namespace ASPDOTNETCOREEmpty_CustomMiddleware
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
         

            //app.MapGet("/", () => "Hello World!");
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("<p> Use Middle ware ---Before </p>");
            //    await next();
            //    await context.Response.WriteAsync("<p> Use Middle ware ---After </p>");
            //});


            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("<p> Run Middle ware ---Before </p>");
            //});


            // next day 31/05/2025
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.MapControllerRoute(
               
                name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
            );

            app.Run();
        }
    }
}
