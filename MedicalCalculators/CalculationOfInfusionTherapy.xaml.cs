namespace PediatricaUI.MedicalCalculators;

public partial class CalculationOfInfusionTherapy : ContentPage
{
	public CalculationOfInfusionTherapy()
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
            if (ValidateInput(WeightEntry.Text, out double weight))
            {
                double dailyVolume = CalculateDailyVolume(weight);
                double hourlyRate = dailyVolume / 24;

                ResultLabel1.Text = $"�������� �����: {dailyVolume:F2} ��";
                ResultLabel2.Text = $"���������� ��������: {hourlyRate:F2} ��/�";
            }
        }
        catch (Exception ex)
        {
            ResultLabel1.Text = $"��������� ������ ��� �������. ��������� ��������� ������. {ex.Message}";
        }
    }

    private bool ValidateInput(string input, out double value)
    {
        // �������� �� ���������� ����� � ������������� ��������
        if (double.TryParse(input, out value) && value > 0)
        {
            return true;
        }

        throw new ArgumentOutOfRangeException(nameof(input));
    }

    private double CalculateDailyVolume(double weight)
    {
        if (weight >= 3.5 && weight <= 10)
        {
            return weight * 100;
        }
        else if (weight > 10 && weight <= 20)
        {
            return 1000 + (weight - 10) * 50;
        }
        else if (weight > 20)
        {
            return Math.Min(1500 + (weight - 20) * 20, 2400);
        }
        else
        {
            throw new ArgumentException("����� ���� ������ ���� ������ 3.5 ��.");
        }
    }
}