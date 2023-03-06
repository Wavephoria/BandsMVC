var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.UseRouting();
// app.MapGet("/", () => "Hello World!!!");
app.UseEndpoints(o => o.MapControllers());

app.Run();


