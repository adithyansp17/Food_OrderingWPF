using System.Configuration;
using System.Data;
using System.Windows;

namespace FoodTOrderWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            bool fullScreen = false;
            foreach (string key in e.Args)
            {
                if (key == "")
                    fullScreen = true;
            }

            this.Properties["Login"] = "DonJoe";
            this.Properties["Password"] = "pwd";

            
        }
    }

}
