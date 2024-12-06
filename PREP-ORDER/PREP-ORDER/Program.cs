namespace PREP_ORDER
{
    internal static class Program
    {
        public static string GetConnectionString()
        {
            return "Server=LAPTOP-MTPE2M3G\\SQLEXPRESS; Database=preporder; Integrated Security=True;";
        }
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Connexion());
        }
    }
}