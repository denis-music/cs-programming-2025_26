using System.Resources;

//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Studentska.WinApp.Helpers
{
    public class Resursi
    {
        static ResourceManager manager = new ResourceManager("Studentska.WinApp.Properties.Resources",
            typeof(frmPrijava).Assembly);

        public static string Get(string kljuc)
        {
            return manager.GetString(kljuc);
        }
    }

}
