using DataAccessLayer.Database;
using PediatricaUI.Views;

namespace PediatricaUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            /*MainPage = new AppShell();*/
            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.FromArgb("#1D03BE"),
                BarTextColor = Colors.White
            };
        }
    }
}
