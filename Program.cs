using Microsoft.EntityFrameworkCore;
using CelilCavus.GreenHosting.Models.Contexts;
using CelilCavus.GreenHosting.UnitOfWork;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();

        builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        builder.Services.AddSqlServer<AppDbContext>("Server=.;Database=AspEFCore_GreenHosting;Trusted_Connection=True;TrustServerCertificate=True;");
        builder.Services.AddScoped <DbContext,AppDbContext>();
        builder.Services.AddScoped<IUow,Uow>();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=AdminPanel}/{action=Index}/{id?}");

        app.Run();
    }
}