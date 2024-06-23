namespace PediatricaUI.MedicalCalculators;

public partial class AnionGap : ContentPage
{
    public AnionGap()
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
            // ��������� �������� �� ����� �����
            double na = double.Parse(NaEntry.Text);
            double cl = double.Parse(ClEntry.Text);
            double hco3 = double.Parse(HCO3Entry.Text);
            if (na < 0 || cl < 0 || hco3 < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            // ���������� �������� �������
            double anionGap = na - (cl + hco3);

            // ����������� ����������
            ResultLabel.Text = $"�������� �������: {anionGap:F2} �����/�";
        }
        catch(Exception ex)
        {
            ResultLabel.Text = "����������, ������� ���������� ��������.";
        }
    }
} 