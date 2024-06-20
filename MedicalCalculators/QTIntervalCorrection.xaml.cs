namespace PediatricaUI.MedicalCalculators;

public partial class QTIntervalCorrection : ContentPage
{
	public QTIntervalCorrection()
	{
		InitializeComponent();
	}

    private void OnCalculateButtonClicked(object sender, EventArgs e)
    {
        if (ValidateInput(QTIntervalEntry.Text, out double qtInterval) && ValidateInput(HeartRateAbbreviationEntry.Text, out double heartRate))
        {
            double RRInterval = 60 / heartRate;
            double QTI = qtInterval / Math.Sqrt(RRInterval);

            // ����������� ����������
            ResultLabel1.Text = $"RR ��������: {RRInterval:F2} ���.";
            ResultLabel2.Text = $"QTI �����������������: {QTI:F2} ���.";
        }
        else
        {
            // ��������� �� ������ �����
            ResultLabel1.Text = "����������, ������� ���������� ��������.";
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