namespace PediatricaUI.Views;

public partial class ArticlesPage : ContentPage
{
	public ArticlesPage()
	{
		InitializeComponent();
    }

	// ��� ���������� ���-���� ���� ������� ���� ������ ����� ��������� ��������� �� ��������

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {

		await DisplayAlert("��������", "����", "Ok");
		/*string articleTitle = (sender as Label).Text; 
		// ������ �������� ������ �� ��������� ������ � ��������������� ���������
		await Navigation.PushAsync(new SingleArticle());*/
    }
}