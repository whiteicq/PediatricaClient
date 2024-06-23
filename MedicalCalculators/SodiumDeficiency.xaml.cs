namespace PediatricaUI.MedicalCalculators;

public partial class SodiumDeficiency : ContentPage
{
	public SodiumDeficiency()
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
        if (ValidateInput(WeightEntry.Text, out double weight) &&
            ValidateInput(SerumSodiumEntry.Text, out double serumSodium) &&
            ValidateInput(DesiredSodiumEntry.Text, out double desiredSodium) &&
            ValidateGenderSelection(out double genderFactor))
        {
            // Вычисление дефицита натрия
            double sodiumDeficit = genderFactor * weight * (desiredSodium - serumSodium);

            // Отображение результата
            ResultLabel.Text = $"Дефицит натрия: {sodiumDeficit:F2} mEq";
        }
        else
        {
            // Сообщение об ошибке ввода
            ResultLabel.Text = "Пожалуйста, введите корректные значения.";
        }
    }

    private bool ValidateInput(string input, out double value)
    {
        // Проверка на корректное число и неотрицательное значение
        if (double.TryParse(input, out value) && value >= 0)
        {
            return true;
        }
        value = 0;
        return false;
    }

    private bool ValidateGenderSelection(out double genderFactor)
    {
        // Проверка выбора пола
        if (MaleRadioButton.IsChecked)
        {
            genderFactor = 0.6;
            return true;
        }
        else if (FemaleRadioButton.IsChecked)
        {
            genderFactor = 0.5;
            return true;
        }
        genderFactor = 0;
        return false;
    }
}