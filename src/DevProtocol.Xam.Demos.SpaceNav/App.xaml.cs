using DevProtocol.Xam.Demos.SpaceNav.Controls;
using Xamarin.Forms;

namespace DevProtocol.Xam.Demos.SpaceNav
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SpaceNavigationPage(new HomePage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
