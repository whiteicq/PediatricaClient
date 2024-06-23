namespace PediatricaUI.MedicalCalculators;

public partial class QTIntervalCorrection : ContentPage
{
	public QTIntervalCorrection()
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
        if (ValidateInput(QTIntervalEntry.Text, out double qtInterval) && ValidateInput(HeartRateAbbreviationEntry.Text, out double heartRate))
        {
            double RRInterval = 60 / heartRate;
            double QTI = qtInterval / Math.Sqrt(RRInterval);

            // Отображение результата
            ResultLabel1.Text = $"RR Интервал: {RRInterval:F2} сек.";
            ResultLabel2.Text = $"QTI Скорректированный: {QTI:F2} сек.";
        }
        else
        {
            // Сообщение об ошибке ввода
            ResultLabel1.Text = "Пожалуйста, введите корректные значения.";
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

}