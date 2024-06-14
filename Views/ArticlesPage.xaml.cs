namespace PediatricaUI.Views;

public partial class ArticlesPage : ContentPage
{
	public ArticlesPage()
	{
		InitializeComponent();
    }

	// для аккордеона все-таки надо сделать норм апишку чтобы связывать Категории со Статьями

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {

		await DisplayAlert("Работает", "Норм", "Ok");
		/*string articleTitle = (sender as Label).Text; 
		// дальше посылать запрос на получение статьи с соответствующим названием
		await Navigation.PushAsync(new SingleArticle());*/
    }
}