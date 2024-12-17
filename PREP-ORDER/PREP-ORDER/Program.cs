namespace PREP_ORDER
{
    internal static class Program
    {
        public static string GetConnectionString()
        {
            return "Server=MSI\\SQLEXPRESS; Database=preporder; Integrated Security=True;"; 
        }

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Gestion_commandes());
        }
    }
}