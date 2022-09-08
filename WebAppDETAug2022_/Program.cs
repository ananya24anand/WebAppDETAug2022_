using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebAppDETAug2022_.Data;
using WebAppDETAug2022_.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Add service dependency of IHelo
builder.Services.AddSingleton<IHelo, Helo1>();

builder.Services.AddDbContext<WebAppDETAug2022_Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebAppDETAug2022_Context") ?? throw new InvalidOperationException("Connection string 'WebAppDETAug2022_Context' not found.")));

var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
