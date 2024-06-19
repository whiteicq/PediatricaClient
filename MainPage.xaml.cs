﻿using DataAccessLayer.Database;
using PediatricaUI.Views;

namespace PediatricaUI
{
    public partial class MainPage : ContentPage
    {
        private ArticleDbContext _db;
        public MainPage(ArticleDbContext db)
        {
            _db = db;
            InitializeComponent();
        }

        private async void ToArticlePage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ArticlesPage(_db));
        }

        private async void ToImagesPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ImagesPage());
        }
    }

}
