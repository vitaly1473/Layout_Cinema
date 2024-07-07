// Program.cs

using Layout_Cinema.Services;
var builder = WebApplication.CreateBuilder(args);

// ��������� � ���������� ������� Razor Pages
builder.Services.AddRazorPages();

// ����������� ������� ��� Singleton
builder.Services.AddSingleton<Films>();
builder.Services.AddSingleton<ScheduleService>();

var app = builder.Build();

// ��������� ��������� ������������� ��� Razor Pages
app.MapRazorPages();

app.Run();

