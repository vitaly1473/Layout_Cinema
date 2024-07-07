// Program.cs

using Layout_Cinema.Services;
var builder = WebApplication.CreateBuilder(args);

// добавляем в приложение сервисы Razor Pages
builder.Services.AddRazorPages();

// регистрация сервиса как Singleton
builder.Services.AddSingleton<Films>();
builder.Services.AddSingleton<ScheduleService>();

var app = builder.Build();

// добавляем поддержку маршрутизации для Razor Pages
app.MapRazorPages();

app.Run();

