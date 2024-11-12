using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TampaPremierLeague.Data;
namespace TampaPremierLeague
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<TampaPremierLeagueContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("TampaPremierLeagueContext") ?? throw new InvalidOperationException("Connection string 'TampaPremierLeagueContext' not found.")));

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
