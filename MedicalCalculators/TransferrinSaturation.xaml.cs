namespace PediatricaUI.MedicalCalculators;

public partial class TransferrinSaturation : ContentPage
{
	public TransferrinSaturation()
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
        if (ValidateInput(FeEntry.Text, out double fe) &&
            ValidateInput(OJSSEntry.Text, out double ojss))
        {
            double KNT = (fe / ojss) * 100;

            // ����������� ����������
            ResultLabel.Text = $"���: {KNT:F2} %";
        }
        else
        {
            // ��������� �� ������ �����
            ResultLabel.Text = "����������, ������� ���������� ��������.";
        }
    }

    private bool ValidateInput(string input, out double value)
    {
        // �������� �� ���������� ����� � ��������������� ��������
        if (double.TryParse(input, out value) && value >= 0)
        {
            return true;
        }
        value = 0;
        return false;
    }

}