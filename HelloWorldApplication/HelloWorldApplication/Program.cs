// Initializes a new instance of the WebApplicationBuilder class with preconfigured defaults.
// https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.builder.webapplication.createbuilder?view=aspnetcore-6.0

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Adds services for pages to the specified IServiceCollection.
builder.Services.AddRazorPages();

//Adds services for controllers to the specified IServiceCollection. This method will not register services used for pages.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAuthorization();

app.MapGet("/hi", () => "Hello!");
app.MapGet("/bye", () => "Bye!");

app.MapDefaultControllerRoute();
app.MapRazorPages();

app.Run();