using System.Collections.ObjectModel;

namespace NetflixClone;

public partial class ComingSoonPage : ContentPage
{
    public ObservableCollection<ComingSoonMovie> ComingSoonMovies { get; set; }

    public ComingSoonPage()
    {
        InitializeComponent();

        // Sample coming soon movies
        ComingSoonMovies = new ObservableCollection<ComingSoonMovie>
            {
                new ComingSoonMovie { Title = "Avatar 4", ReleaseDate = "December 16, 2025" },
                new ComingSoonMovie { Title = "The Hitler", ReleaseDate = "March 4, 2025" },
                new ComingSoonMovie { Title = "Jurassic World: far From Home", ReleaseDate = "June 10, 2025" },
                new ComingSoonMovie { Title = "The One My Heart Desire", ReleaseDate = "May 6, 2025" },
                new ComingSoonMovie { Title = "One Here,The Other There", ReleaseDate = "November 11, 2025" }
            };

        ComingSoonMoviesList.ItemsSource = ComingSoonMovies;
    }
}

public class ComingSoonMovie
{
    public string Title { get; set; }
    public string ReleaseDate { get; set; }
}
