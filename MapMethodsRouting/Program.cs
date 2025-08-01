var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.Map("/Home", () => "Hello World!"); Map method goes with everything like Get,Post,Put and Delete

//app.MapGet("/Home", () => "Hello World - Get Method");
//app.MapPost("/Home", () => "Hello World - Post Method");
//app.MapPut("/Home", () => "Hello World - Put Method");
//app.MapDelete("/Home", () => "Hello World - Delete Method");

//Defining endpoints using delegates
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/Home",async (context) =>
    {
        await context.Response.WriteAsync("Hello World - Get Method");
    });
    endpoints.MapPost("/Home",async (context) =>
    {
        await context.Response.WriteAsync("Hello World - Post Method");
    });
    endpoints.MapPut("/Home", async (context) =>
    {
        await context.Response.WriteAsync("Hello World - Put Method");
    });
    endpoints.MapDelete("/Home", async (context) =>
    {
        await context.Response.WriteAsync("Hello World - Delete Method");
    });
});

app.Run(async(HttpContext context) =>
{
    await context.Response.WriteAsync("Page not found...");
});


app.Run();
