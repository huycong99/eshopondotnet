using Microsoft.EntityFrameworkCore;
using Product.EF.Infrastructure;

namespace Product.API
{
    public static class ProgramExtensions
    {
        public static void AddCustomDbContext(this WebApplicationBuilder builder)
        {
            var connectionString = builder.Configuration["ConnectionString"];
            builder.Services.AddDbContextFactory<ProductDbContext>(
                options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString), b => b.MigrationsAssembly("Product.EF")));
        }

        public static void AddCustomMigration(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<ProductDbContext>();
            context.Database.Migrate();
        }

        public static void AddCustomApplicationService(this WebApplicationBuilder builder)
        {
            // DI zô đây
        }


    }
}
