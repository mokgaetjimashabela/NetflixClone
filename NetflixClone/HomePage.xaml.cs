namespace NetflixClone;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}
    private async void OnMovieClicked(object sender, EventArgs e)
    {
        // Navigate to the movie/TV show details page
        await Navigation.PushAsync(new MovieDetailPage());
    }
}