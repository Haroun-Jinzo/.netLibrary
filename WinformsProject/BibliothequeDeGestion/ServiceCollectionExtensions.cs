using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BibliothequeDeGestion.Repositories;
using BibliothequeDeGestion.Forms;
using BibliothequeDeGestion.BookForms;
using BibliothequeDeGestion.MemberForms;
using BibliothequeDeGestion.LoanForms;


namespace BibliothequeDeGestion
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Enregistrer LibraryeContext avec les options SQLite et initialiser la base de données avec des données de test
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddLibraryNotebookDataService(this IServiceCollection services)
        {
            services.AddDbContext<LibraryContext>(options =>
            {
                options.UseSqlite("Data Source=library.db");
                // Utiliser Seeding pour initialiser la base de données avec des données de test
                options.UseSeeding((context, _) =>
                {
                    //(context as LibraryContext).Seed();
                });
            }
            // Utiliser Transient pour éviter les problèmes de scope dans winforms
            , ServiceLifetime.Transient
            );

            // Enregistrer les repositories
            services.AddTransient<BookRepository>();
            services.AddTransient<LoanRepository>();
            services.AddTransient<MemberRepository>();
            services.AddTransient<EmailService>();

            return services;
        }

        /// <summary>
        /// Appliquer les migrations au démarrage
        /// </summary>
        /// <param name="services"></param>
        public static void ApplyMigrationsForLibraryNotebookDataService(this IServiceCollection services)
        {
            var serviceProvider = services.BuildServiceProvider();
            using (var scope = serviceProvider.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<LibraryContext>();
                var pendingMigrations = dbContext.Database.GetPendingMigrations();
                if (pendingMigrations.Any())
                {
                    dbContext.Database.Migrate();
                }
            }
        }

        public static void RegisterForms(this IServiceCollection services)
        {
            services.AddTransient<MainForm>();
            services.AddTransient<BookManagementForm>();
            services.AddTransient<BookDetaliForm>();
            services.AddTransient<MemberManagementForm>();
            services.AddTransient<MemberDetailForm>();
            services.AddTransient<LoanManagementForm>();
            services.AddTransient<LoanDetailForm>();
            // add loan forms
        }
    }
}
