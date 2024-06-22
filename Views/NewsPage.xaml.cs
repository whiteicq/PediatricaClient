using PediatricaUI.NewsPages;

namespace PediatricaUI.Views;

public partial class NewsPage : ContentPage
{
	public NewsPage()
	{
		InitializeComponent();
	}
    private async void TapGestureRecognizer_Tapped1(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new ManyPatientsExperienceWithdrawalSymptoms());
    }
    private async void TapGestureRecognizer_Tapped2(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new GastrectomyForStomachCancer());
    }
    private async void TapGestureRecognizer_Tapped3(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new OverallRiskOfDeath());
    }
    private async void TapGestureRecognizer_Tapped4(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new ShortSleepDuration());
    }
    private async void TapGestureRecognizer_Tapped5(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new GlobalLifeExpectancy());
    }
    private async void TapGestureRecognizer_Tapped6(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new NeuropsychiatricSymptoms());
    }
    private async void TapGestureRecognizer_Tapped7(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new Obese());
    }
    private async void TapGestureRecognizer_Tapped8(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new AddingCardiovascularBiomarkers());
    }
    private async void TapGestureRecognizer_Tapped9(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new Thrombectomy());
    }
    private async void TapGestureRecognizer_Tapped10(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new DopplerUltrasound());
    }
    private async void TapGestureRecognizer_Tapped11(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new HealthyLifestyle());
    }
    private async void TapGestureRecognizer_Tapped12(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new WeightBearingPhysicalActivity());
    }private async void TapGestureRecognizer_Tapped13(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new PrenatalOpioidExposure());
    }
}