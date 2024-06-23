using PediatricaUI.ArticlePages.SymptomsInInfantsAndYoungChildren;
using PediatricaUI.ArticlePages.MedicalSupervisionOfHealthyChild;
using PediatricaUI.ArticlePages.Vaccination;
using PediatricaUI.ArticlePages.BehavioralDisordersAndProblemsInChildren;
using PediatricaUI.ArticlePages.CourseOnCaringForSickChildrenAndTheirFamilies;
using PediatricaUI.ArticlePages.ChildAbuse;
using PediatricaUI.ArticlePages.CongenitalDisordersOfTubularTransport;

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
    }
    private async void TapGestureRecognizer_Tapped14(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new VaccineHesitancy());
    }
    private async void TapGestureRecognizer_Tapped15(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new OverviewOfBehavioralDisordersInChildren());
    }
    private async void TapGestureRecognizer_Tapped16(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new BreathHoldingSpells());
    }
    private async void TapGestureRecognizer_Tapped17(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new EatingDisorders());
    }
    private async void TapGestureRecognizer_Tapped18(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new SchoolAvoidance());
    }
    private async void TapGestureRecognizer_Tapped19(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new SleepDisorders());
    }
    private async void TapGestureRecognizer_Tapped20(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new Tantrums());
    }
    private async void TapGestureRecognizer_Tapped21(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new Violence());
    }
    private async void TapGestureRecognizer_Tapped22(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new CaringForSickNewborns());
    }
    private async void TapGestureRecognizer_Tapped23(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new ChildrenWithChronicDiseases());
    }
    private async void TapGestureRecognizer_Tapped24(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new DeathAndDyingOfChildren());
    }
    private async void TapGestureRecognizer_Tapped25(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new OverviewOfChildMaltreatment());
    }
    private async void TapGestureRecognizer_Tapped26(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new DamageToFemaleGenitalOrgans());
    }
    private async void TapGestureRecognizer_Tapped27(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new BartterSyndromeAndGitelmanSyndrome());
    }
    private async void TapGestureRecognizer_Tapped28(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new Cystinuria());
    }
    private async void TapGestureRecognizer_Tapped29(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new HypophosphatemicRickets());
    }
}