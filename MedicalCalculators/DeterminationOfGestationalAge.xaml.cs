namespace PediatricaUI.MedicalCalculators;

public partial class DeterminationOfGestationalAge : ContentPage
{
	public DeterminationOfGestationalAge()
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
            DateTime currentDate = CurrentDatePicker.Date;
            DateTime lmpDate = LMPDatePicker.Date;
            DateTime usDate = UltrasoundDatePicker.Date;

            double? crl = string.IsNullOrWhiteSpace(CRLMeasurement.Text) ? (double?)null : double.Parse(CRLMeasurement.Text);
            double? bpd = string.IsNullOrWhiteSpace(BPDMeasurement.Text) ? (double?)null : double.Parse(BPDMeasurement.Text);
            double? hc = string.IsNullOrWhiteSpace(HCMeasurement.Text) ? (double?)null : double.Parse(HCMeasurement.Text);

            CalculatePregnancyDates(currentDate, lmpDate, usDate, crl, bpd, hc);
        }
        catch (Exception ex)
        {
            ResultLabel1.Text = "����������, ������� ���������� ������.";
        }
    }

    private void CalculatePregnancyDates(DateTime currentDate, DateTime lmpDate, DateTime usDate, double? crl, double? bpd, double? hc)
    {
        string result1, result2, result3, result4, result5, result6, result7, result8; 

        // ������������ �� ����������� � ���� ����� �� �����������
        TimeSpan pregnancyByLMP = currentDate - lmpDate;
        DateTime dueDateByLMP = lmpDate.AddDays(280);
        result1 = $"������������ �� �����������: {pregnancyByLMP.Days / 7} ������";
        result2 = $"���� ����� �� �����������: {dueDateByLMP:dd/MM/yyyy}";

        // ������������ �� ��� � ���� ����� �� ���
        if (!crl.HasValue || !bpd.HasValue || !hc.HasValue)
        {
            throw new ArgumentNullException();
        }

        double weeksByCRL = 5.2876 + (0.1584 * crl.Value) - (0.0007 * crl.Value * crl.Value);
        DateTime dueDateByCRL = usDate.AddDays((280 - weeksByCRL * 7));
        result3 = $"������������ �� ���: {weeksByCRL:F2} ������";
        result4 = $"���� ����� �� ���: {dueDateByCRL:dd/MM/yyyy}";

        // ������������ �� ��� � ���� ����� �� ���

        double daysByBPD = 2 * bpd.Value + 44.2;
        double weeksByBPD = daysByBPD / 7;
        DateTime dueDateByBPD = usDate.AddDays((280 - daysByBPD));
        result5 = $"������������ �� ���: {weeksByBPD:F2} ������";
        result6 = $"���� ����� �� ���: {dueDateByBPD:dd/MM/yyyy}";

        // ������������ �� �� � ���� ����� �� ��
        double weeksByHC = Math.Exp(1.854 + (0.010451 * hc.Value) - (0.000029919 * hc.Value * hc.Value) + (0.000000043156 * hc.Value * hc.Value * hc.Value));
        DateTime dueDateByHC = usDate.AddDays((280 - weeksByHC * 7));
        result7 = $"������������ �� ��: {weeksByHC:F2} ������";
        result8 = $"���� ����� �� ��: {dueDateByHC:dd/MM/yyyy}";

        ResultLabel1.Text = result1;
        ResultLabel2.Text = result2;
        ResultLabel3.Text = result3;
        ResultLabel4.Text = result4;
        ResultLabel5.Text = result5;
        ResultLabel6.Text = result6;
        ResultLabel7.Text = result7;
        ResultLabel8.Text = result8;

    }
}