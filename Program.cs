using MyM26.UI;

namespace MyM26
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //verificamos si es la primera vez que habre la app
            if(Properties.Settings.Default.PrimeraEjecucion)
            {
                //si cumple con la condicion, se abre el formulario de registro de usuario
                Application.Run(new registroDeUser());
            }
            else
            {
                //de lo contrario , se abre el formulario de login
                Application.Run(new Login());
            }
            
        }
    }
}