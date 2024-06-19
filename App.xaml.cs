using DataAccessLayer.Database;
using PediatricaUI.Views;

namespace PediatricaUI
{
    public partial class App : Application
    {
        private ArticleDbContext _db;
        public App(ArticleDbContext db)
        {
            _db = db;
            InitializeComponent();
            /*MainPage = new AppShell();*/
            MainPage = new NavigationPage(new MainPage(_db))
            {
                BarBackgroundColor = Color.FromArgb("#1D03BE"),
                BarTextColor = Colors.White
            };
        }
    }
}
