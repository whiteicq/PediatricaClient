namespace PediatricaUI.VideoPages;

public partial class DisconnectionOfTheSac : ContentPage
{
	public DisconnectionOfTheSac()
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
}