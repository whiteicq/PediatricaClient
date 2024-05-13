namespace PediatricaUI.Views;

public partial class ArticlePage : ContentPage
{
	public ArticlePage()
	{
		InitializeComponent();
	}

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		await Navigation.PushAsync(new SingleArticle());
    }
}