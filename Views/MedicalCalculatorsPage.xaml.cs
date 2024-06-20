using PediatricaUI.MedicalCalculators;

namespace PediatricaUI.Views;

public partial class MedicalCalculatorsPage : ContentPage
{
	public MedicalCalculatorsPage()
	{
		InitializeComponent();
	}

    private async void TapGestureRecognizer_Tapped1(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new AnionGap());
    }
    private async void TapGestureRecognizer_Tapped2(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new SodiumDeficiency());
    }
    private async void TapGestureRecognizer_Tapped3(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new QTIntervalCorrection());
    }
    private async void TapGestureRecognizer_Tapped4(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new TransferrinSaturation());
    }
}