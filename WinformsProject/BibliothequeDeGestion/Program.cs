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

            // Construction du fournisseur de services qui g�re les instances des d�pendances  
            ServiceProvider = services.BuildServiceProvider();

            // Appliquer les migrations au d�marrage  
            services.ApplyMigrationsForLibraryNotebookDataService();

            // R�cup�ration de l'instance de la fen�tre principale via l'injection de d�pendances  
            var mainForm = ServiceProvider.GetRequiredService<MainForm>();
            // D�marrage de l'application avec la fen�tre principale  
            Application.Run(mainForm);
        }
    }
}