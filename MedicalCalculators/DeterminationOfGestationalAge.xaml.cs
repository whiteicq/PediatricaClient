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
            ResultLabel1.Text = "Пожалуйста, введите корректные данные.";
        }
    }

    private void CalculatePregnancyDates(DateTime currentDate, DateTime lmpDate, DateTime usDate, double? crl, double? bpd, double? hc)
    {
        string result1, result2, result3, result4, result5, result6, result7, result8; 

        // Беременность по менструации и дата родов по менструации
        TimeSpan pregnancyByLMP = currentDate - lmpDate;
        DateTime dueDateByLMP = lmpDate.AddDays(280);
        result1 = $"Беременность по менструации: {pregnancyByLMP.Days / 7} недель";
        result2 = $"Дата родов по менструации: {dueDateByLMP:dd/MM/yyyy}";

        // Беременность по КТР и дата родов по КТР
        if (!crl.HasValue || !bpd.HasValue || !hc.HasValue)
        {
            throw new ArgumentNullException();
        }

        double weeksByCRL = 5.2876 + (0.1584 * crl.Value) - (0.0007 * crl.Value * crl.Value);
        DateTime dueDateByCRL = usDate.AddDays((280 - weeksByCRL * 7));
        result3 = $"Беременность по КТР: {weeksByCRL:F2} недель";
        result4 = $"Дата родов по КТР: {dueDateByCRL:dd/MM/yyyy}";

        // Беременность по БПР и дата родов по БПР

        double daysByBPD = 2 * bpd.Value + 44.2;
        double weeksByBPD = daysByBPD / 7;
        DateTime dueDateByBPD = usDate.AddDays((280 - daysByBPD));
        result5 = $"Беременность по БПР: {weeksByBPD:F2} недель";
        result6 = $"Дата родов по БПР: {dueDateByBPD:dd/MM/yyyy}";

        // Беременность по ОГ и дата родов по ОГ
        double weeksByHC = Math.Exp(1.854 + (0.010451 * hc.Value) - (0.000029919 * hc.Value * hc.Value) + (0.000000043156 * hc.Value * hc.Value * hc.Value));
        DateTime dueDateByHC = usDate.AddDays((280 - weeksByHC * 7));
        result7 = $"Беременность по ОГ: {weeksByHC:F2} недель";
        result8 = $"Дата родов по ОГ: {dueDateByHC:dd/MM/yyyy}";

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