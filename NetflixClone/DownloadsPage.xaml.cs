using System.Collections.ObjectModel;

namespace NetflixClone;

public partial class DownloadsPage : ContentPage
{
    public ObservableCollection<DownloadedMovie> DownloadedMovies { get; set; }

    public DownloadsPage()
    {
        InitializeComponent();

        // Sample downloaded movies
        DownloadedMovies = new ObservableCollection<DownloadedMovie>
            {
                new DownloadedMovie { Title = "Inception", Category = "Sci-Fi" },
                new DownloadedMovie { Title = "The Dark Knight", Category = "Action" },
                new DownloadedMovie { Title = "Forrest Gump", Category = "Drama" },
                new DownloadedMovie { Title = "The Matrix", Category = "Sci-Fi" },
                new DownloadedMovie { Title = "Toy Story", Category = "Animation" }
            };

        DownloadedMoviesList.ItemsSource = DownloadedMovies;
    }
}

public class DownloadedMovie
{
    public string Title { get; set; }
    public string Category
    {
        get; set;
    }
}