using BibliothequeDeGestion.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace BibliothequeDeGestion
{
    public static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; } = null!;

        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            // Enregistrer RecipeContext avec les options SQLite  
            services.AddLibraryNotebookDataService();

            

            // Initialisation de la configuration de l'application  
            ApplicationConfiguration.Initialize();

            // Enregistrer les Forms  
            services.RegisterForms();

            // Construction du fournisseur de services qui gère les instances des dépendances  
            ServiceProvider = services.BuildServiceProvider();

            // Appliquer les migrations au démarrage  
            services.ApplyMigrationsForLibraryNotebookDataService();

            // Récupération de l'instance de la fenêtre principale via l'injection de dépendances  
            var mainForm = ServiceProvider.GetRequiredService<MainForm>();
            // Démarrage de l'application avec la fenêtre principale  
            Application.Run(mainForm);
        }
    }
}