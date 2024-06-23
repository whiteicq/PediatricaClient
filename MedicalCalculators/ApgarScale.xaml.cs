namespace PediatricaUI.MedicalCalculators;

public partial class ApgarScale : ContentPage
{
	public ApgarScale()
	{
		InitializeComponent();
	}
    private bool isAddToFavourite = false;
    private void ToolbarItem_Clicked(object sender, EventArgs e)
    {
        isAddToFavourite = !isAddToFavourite;
        if (isAddToFavourite)
        {
            starForFavourites.IconImageSource = ImageSource.FromFile("star_post.png");
        }
        else
        {
            starForFavourites.IconImageSource = ImageSource.FromFile("star_before.png");
        }
    }
    private void OnCalculateButtonClicked(object sender, EventArgs e)
    {
        try
        {
            int heartRate = GetRadioButtonValue(HeartRate_2, HeartRate_1, HeartRate_0);
            int breathing = GetRadioButtonValue(Breathing_2, Breathing_1, Breathing_0);
            int muscleTone = GetRadioButtonValue(MuscleTone_2, MuscleTone_1, MuscleTone_0);
            int skinColor = GetRadioButtonValue(SkinColor_2, SkinColor_1, SkinColor_0);
            int reflexResponse = GetRadioButtonValue(ReflexResponse_2, ReflexResponse_1, ReflexResponse_0);

            if (heartRate < 0 || breathing < 0 || muscleTone < 0 || skinColor < 0 || reflexResponse < 0)
            {
                ResultLabel.Text = "Пожалуйста, выберите все параметры.";
                return;
            }

            int totalScore = heartRate + breathing + muscleTone + skinColor + reflexResponse;
            string result = $"Общий балл по шкале Апгар: {totalScore}\n";

            if (totalScore >= 7)
            {
                result += "Норма";
            }
            else
            {
                result += "Патологическое состояние";
            }

            ResultLabel.Text = result;
        }
        catch (Exception ex)
        {
            ResultLabel.Text = "Произошла ошибка при расчете. Проверьте введенные данные.";
        }
    }

    private int GetRadioButtonValue(RadioButton rb2, RadioButton rb1, RadioButton rb0)
    {
        if (rb2.IsChecked) return 2;
        if (rb1.IsChecked) return 1;
        if (rb0.IsChecked) return 0;
        return -1; // Не выбрано значение
    }
}