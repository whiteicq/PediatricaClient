
using DataAccessLayer.Database;

namespace PediatricaUI.Views;

public partial class ArticlesPage : ContentPage
{
    private ArticleDbContext _db;
	public ArticlesPage(ArticleDbContext db)
	{
        _db = db;
		InitializeComponent();
    }


    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Label currLabel = sender as Label;
        string titleArticle = currLabel.Text;

/*        var currArticle = _db.Articles.FirstOrDefault(article => article.Title == titleArticle);
*/
        await Navigation.PushAsync(new SingleArticle(/*currArticle*/));
    }
}