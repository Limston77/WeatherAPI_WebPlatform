using BlazorApp1.Components;
using Blazorise;
using Blazorise.Bootstrap5;
using Blazorise.Icons.FontAwesome;
using Microsoft.AspNetCore.Components;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Регистрация Razor Components
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Регистрация HttpClient
builder.Services.AddHttpClient();

// Регистрация Blazorise с Bootstrap5 и FontAwesome
builder.Services
    .AddBlazorise(options =>
    {
        options.Immediate = true;
    })
    .AddBootstrap5Providers()
    .AddFontAwesomeIcons();

// Регистрация провайдера CORS политики
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});



// Создание приложения
var app = builder.Build();

// Регистрация провайдера кодировок
Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}



// Использование статических файлов
app.UseStaticFiles();

// Включение CORS политики
app.UseCors("AllowAll");

// Защита от подделки запросов
app.UseAntiforgery();

// Настройка маршрутов Razor Components
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Запуск приложения
app.Run();
