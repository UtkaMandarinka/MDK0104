namespace Блокнот
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
            String[] arguments = Environment.GetCommandLineArgs();
            if (arguments.Length >= 2)
            {
                Application.Run(new MainForm(arguments[1]));
            }
            else
            {
                Application.Run(new MainForm());
            }
        }
    }
}