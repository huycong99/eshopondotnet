using Microsoft.EntityFrameworkCore;
using User.EF.Infrastructure;

namespace User.API
{
    public static class ProgramExtentions
    {
        public static void AddCustomDbContext(this WebApplicationBuilder builder)
        {
            var connectionString = builder.Configuration["ConnectionString"];
            builder.Services.AddDbContextFactory<UserDbContext>(
                options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString), b => b.MigrationsAssembly("User.EF")));
        }

        public static void AddCustomMigration(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<UserDbContext>();
            context.Database.Migrate();
        }

        public static void AddCustomApplicationService(this WebApplicationBuilder builder)
        {
            // DI zô đây
        }
    }
}
