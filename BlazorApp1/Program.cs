using BlazorApp1.Components;
using Blazorise;
using Blazorise.Bootstrap5;
using Blazorise.Icons.FontAwesome;
using Microsoft.AspNetCore.Components;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// ����������� Razor Components
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// ����������� HttpClient
builder.Services.AddHttpClient();

// ����������� Blazorise � Bootstrap5 � FontAwesome
builder.Services
    .AddBlazorise(options =>
    {
        options.Immediate = true;
    })
    .AddBootstrap5Providers()
    .AddFontAwesomeIcons();

// ����������� ���������� CORS ��������
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});



// �������� ����������
var app = builder.Build();

// ����������� ���������� ���������
Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}



// ������������� ����������� ������
app.UseStaticFiles();

// ��������� CORS ��������
app.UseCors("AllowAll");

// ������ �� �������� ��������
app.UseAntiforgery();

// ��������� ��������� Razor Components
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// ������ ����������
app.Run();
