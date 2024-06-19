using PediatricaUI.ImagePages;

namespace PediatricaUI.Views;

public partial class ImagesPage : ContentPage
{
	public ImagesPage()
	{
		InitializeComponent();
	}

    private async void TapGestureRecognizer_Tapped1(object sender, TappedEventArgs e)
    {
		await Navigation.PushAsync(new EarImplant());
	}

    private async void TapGestureRecognizer_Tapped2(object sender, TappedEventArgs e)
    {
		await Navigation.PushAsync(new PAPA());
    }
	
	private async void TapGestureRecognizer_Tapped3(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new VacterlUp());
    }
    private async void TapGestureRecognizer_Tapped4(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new VacterlDown());
    }
	private async void TapGestureRecognizer_Tapped5(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new WDermatit());
    }
	private async void TapGestureRecognizer_Tapped6(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new Angiokeratoma());
    }
	private async void TapGestureRecognizer_Tapped7(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new Angiofibroma());
    }
	private async void TapGestureRecognizer_Tapped8(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new Anoftalmia());
    }
	private async void TapGestureRecognizer_Tapped9(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new AtopDermatit());
    }
	private async void TapGestureRecognizer_Tapped10(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new Atrezia());
    }
	private async void TapGestureRecognizer_Tapped11(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new BacterialTraheitRentgen());
    }
	private async void TapGestureRecognizer_Tapped12(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new BacterialTraheitEndoscope());
    }
	private async void TapGestureRecognizer_Tapped13(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new RashkindProcedure());
    }
	private async void TapGestureRecognizer_Tapped14(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new HirschsprungsDisease());
    }
	private async void TapGestureRecognizer_Tapped15(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new KawasakiDisease());
    }
	private async void TapGestureRecognizer_Tapped16(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new TaySachsDisease());
    }
	private async void TapGestureRecognizer_Tapped17(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new BronchopulmonaryDysplasia());
    }
	private async void TapGestureRecognizer_Tapped18(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new XLegs());
    }
}