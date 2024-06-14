namespace PediatricaUI.Views;

public partial class ImagesPage : ContentPage
{
	public ImagesPage()
	{
		InitializeComponent();
	}

    private async void TapGestureRecognizer_Tapped1(object sender, TappedEventArgs e)
    {
		await Navigation.PushAsync(new SingleImage());
    }
}