using PediatricaUI.VideoPages;

namespace PediatricaUI.Views;

public partial class VideoPage : ContentPage
{
	public VideoPage()
	{
		InitializeComponent();
	}

    private async void TapGestureRecognizer_Tapped1(object sender, TappedEventArgs e)
    {
		await Navigation.PushAsync(new LaparoscopicLaddProcedure());
    }
    private async void TapGestureRecognizer_Tapped2(object sender, TappedEventArgs e)
    {
		await Navigation.PushAsync(new LowAnorectalMalformations());
    }
    private async void TapGestureRecognizer_Tapped3(object sender, TappedEventArgs e)
    {
		await Navigation.PushAsync(new LeftNonPalpableUDT());
    }
    private async void TapGestureRecognizer_Tapped4(object sender, TappedEventArgs e)
    {
		await Navigation.PushAsync(new NeedleInsertionThroughAnteriorAbdominalWall());
    }
    private async void TapGestureRecognizer_Tapped5(object sender, TappedEventArgs e)
    {
		await Navigation.PushAsync(new IlealFlange());
    }
    private async void TapGestureRecognizer_Tapped6(object sender, TappedEventArgs e)
    {
		await Navigation.PushAsync(new LaparoscopicPercutaneousInguinalHerniaRepair());
    }
    private async void TapGestureRecognizer_Tapped7(object sender, TappedEventArgs e)
    {
		await Navigation.PushAsync(new HypertrophicPyloricSterosisInfant());
    }
    private async void TapGestureRecognizer_Tapped8(object sender, TappedEventArgs e)
    {
		await Navigation.PushAsync(new LaparscopicExcisionOfHydatidCyst());
    }
    private async void TapGestureRecognizer_Tapped9(object sender, TappedEventArgs e)
    {
		await Navigation.PushAsync(new DisconnectionOfTheSac());
    }
    private async void TapGestureRecognizer_Tapped10(object sender, TappedEventArgs e)
    {
		await Navigation.PushAsync(new StoneInCysticDuctDiverticulum());
    }
    private async void TapGestureRecognizer_Tapped11(object sender, TappedEventArgs e)
    {
		await Navigation.PushAsync(new RightOvarianTorsion());
    }
    private async void TapGestureRecognizer_Tapped12(object sender, TappedEventArgs e)
    {
		await Navigation.PushAsync(new CongenitalCricopharyngealDiverticulum());
    }
    private async void TapGestureRecognizer_Tapped13(object sender, TappedEventArgs e)
    {
		await Navigation.PushAsync(new CholedochalCystExcision());
    }
    private async void TapGestureRecognizer_Tapped14(object sender, TappedEventArgs e)
    {
		await Navigation.PushAsync(new LaparoscopicAppendectomy());
    }
    private async void TapGestureRecognizer_Tapped15(object sender, TappedEventArgs e)
    {
		await Navigation.PushAsync(new LaparoscopicRightInguinalHerniaRepair());
    }
}