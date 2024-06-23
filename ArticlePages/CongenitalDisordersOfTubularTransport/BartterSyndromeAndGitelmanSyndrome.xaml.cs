namespace PediatricaUI.ArticlePages.CongenitalDisordersOfTubularTransport;

public partial class BartterSyndromeAndGitelmanSyndrome : ContentPage
{
	public BartterSyndromeAndGitelmanSyndrome()
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