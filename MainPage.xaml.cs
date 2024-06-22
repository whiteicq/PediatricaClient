using DataAccessLayer.Database;
using PediatricaUI.Views;

namespace PediatricaUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ToArticlePage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ArticlesPage());
        }

        private async void ToImagesPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ImagesPage());
        }

        private async void ToVideoPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VideoPage());
        }

        private async void ToCalculatorsPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MedicalCalculatorsPage());
        }

        private async void ToNewsPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewsPage());
        }
    }

}
