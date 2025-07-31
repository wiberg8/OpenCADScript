using System.Text.Json;

namespace OpenCAD
{
    internal static class Program
    {
        public static PreSelectSettings PreSelectSettings = new();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            try
            {
                try
                {
                    if (File.Exists("settings.json"))
                    {
                        var temp = JsonSerializer.Deserialize<PreSelectSettings>(File.ReadAllText("settings.json")) ?? new();
                        PreSelectSettings = temp;
                        PreSelectSettings.SourceFiles = PreSelectSettings.SourceFiles.Where(File.Exists)
                            .ToList();
                    }
                }
                catch (Exception)
                {
                }
                ApplicationConfiguration.Initialize();
                Application.Run(new Form1());
                File.WriteAllText("settings.json", JsonSerializer.Serialize(PreSelectSettings));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}