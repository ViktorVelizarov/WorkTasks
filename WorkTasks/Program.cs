using WorkTasks.Classes;

namespace WorkTasks
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Company myCompany = new Company("company1");
            HelperFuncitons hf = new HelperFuncitons(myCompany);
            Application.Run(new HomePage(myCompany));
          
        }
    }
}