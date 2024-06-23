namespace PediatricaUI.MedicalCalculators;

public partial class BodySurfaceArea : ContentPage
{
	public BodySurfaceArea()
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
            if (ValidateInput(WeightEntry.Text, out double weight) &&
                ValidateInput(HeightEntry.Text, out double height))
            {
                double bsa = BSA(height, weight);
                ResultLabel.Text = $"Площадь поверхности тела: {bsa:F2} м²";
            }
            else
            {
                ResultLabel.Text = "Пожалуйста, введите корректные значения для веса и роста.";
            }
        }
        catch (Exception ex)
        {
            ResultLabel.Text = "Произошла ошибка при расчете. Проверьте введенные данные.";
        }
    }

	private double BSA(double height, double weight)
	{

		return 0.007184 * Math.Pow(height, 0.725) * Math.Pow(weight, 0.425);
    }

    private bool ValidateInput(string input, out double value)
    {
        // Проверка на корректное число и неотрицательное значение
        if (double.TryParse(input, out value) && value > 0)
        {
            return true;
        }

        throw new ArgumentOutOfRangeException(nameof(input));
    }
}