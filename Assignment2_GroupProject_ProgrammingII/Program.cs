namespace Assignment2_GroupProject_ProgrammingII
{
    internal static class Program
    {/// <summary>
     /// The main entry point for the application.
     /// </summary>
        [STAThread]
        static void Main()
        {
            // Perform additional initialization tasks here if needed

            // Example: Initialize application configuration
            ApplicationConfiguration.Initialize();

            // Start the application with the MainForm
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}