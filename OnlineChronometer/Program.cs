using OnlineChronometer.Components;
using OnlineChronometer.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Register your service
builder.Services.AddSingleton<ChronometerService>();

var app = builder.Build();

// Configure pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();
app.UseAntiforgery();

// Map components (Blazor)
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();