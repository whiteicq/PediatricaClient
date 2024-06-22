using PediatricaUI.ArticlePages.SymptomsInInfantsAndYoungChildren;
using PediatricaUI.ArticlePages.MedicalSupervisionOfHealthyChild;
using PediatricaUI.ArticlePages.Vaccination;

namespace PediatricaUI.Views;

public partial class ArticlesPage : ContentPage
{
	public ArticlesPage()
	{
		InitializeComponent();
    }
    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs eventArgs)
    {

    }
    // Симтомы у детей грудного и младшего возраста
    private async void TapGestureRecognizer_Tapped1(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new Colic());
    }
    private async void TapGestureRecognizer_Tapped2(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new Constipation());
    }
    private async void TapGestureRecognizer_Tapped3(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new Cough());
    }private async void TapGestureRecognizer_Tapped4(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new Cry());
    }
    private async void TapGestureRecognizer_Tapped5(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new Diarrhea());
    }
    private async void TapGestureRecognizer_Tapped6(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new Fever());
    }
    private async void TapGestureRecognizer_Tapped7(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new Nausea());
    }
    private async void TapGestureRecognizer_Tapped8(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new Rash());
    }
    private async void TapGestureRecognizer_Tapped9(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new SeparationAnxiety());
    }
    private async void TapGestureRecognizer_Tapped10(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new MedicalSupervisionOfHealthyChild());
    }
    private async void TapGestureRecognizer_Tapped11(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new ScreeningTests());
    }
    private async void TapGestureRecognizer_Tapped12(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new ToiletTraining());
    }
    private async void TapGestureRecognizer_Tapped13(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new Vaccination());
    }private async void TapGestureRecognizer_Tapped14(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new VaccineHesitancy());
    }
}