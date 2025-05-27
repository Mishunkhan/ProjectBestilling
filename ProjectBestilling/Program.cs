var builder = WebApplication.CreateBuilder(args);


/*
 * builder.Services.AddControllersWithViews(); adds services required for
 * handling controllers and views to the dependency injection
 * container. It sets up the application to use the MVC (Model-View-Controller)
 * pattern for handling HTTP requests.
 */
builder.Services.AddControllersWithViews();

var app = builder.Build();


/*
 * app.MapDefaultControllerRoute(); maps the default controller route for the 
 * application. It sets up a route that matches URLs to controller actions based 
 * on conventional patterns. For example, a URL like "/Item/List" would map to the
 * List action in the ItemController.
 * 
 * app.MapDefaultControllerRoute(); method also adds a middleware to the pipeline.
 * This middleware handles the routing of incoming requests to the appropriate 
 * controller and action based on the defined routes.
 */
app.MapDefaultControllerRoute();

/*
 Middlewares in ASP.NET Core are components that sit in the request/response
processing pipeline and can perform various operations on the incoming HTTP
request or outgoing response. app.Run(); method adds a middleware to the application.
This middleware is the final piece in the pipeline and is responsible for handling the
request and generating the response. It is executed when the pipeline reaches the end 
and no other middleware has handled the request.
 */
app.Run();
