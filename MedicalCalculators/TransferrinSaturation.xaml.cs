namespace PediatricaUI.MedicalCalculators;

public partial class TransferrinSaturation : ContentPage
{
	public TransferrinSaturation()
	{
		InitializeComponent();
	}

    private void OnCalculateButtonClicked(object sender, EventArgs e)
    {
        if (ValidateInput(FeEntry.Text, out double fe) &&
            ValidateInput(OJSSEntry.Text, out double ojss))
        {
            double KNT = (fe / ojss) * 100;

            // Отображение результата
            ResultLabel.Text = $"КНТ: {KNT:F2} %";
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

}