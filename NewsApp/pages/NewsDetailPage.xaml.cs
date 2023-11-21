using NewsApp.Models;

namespace NewsApp.pages;

public partial class NewsDetailPage : ContentPage
{
	public NewsDetailPage(Article article)
	{
		InitializeComponent();
		ImgNews.Source = article.Image;
		LblTitle.Text = article.Title;
		LblContent.Text = article.Content;
	}
}