using System.Collections.ObjectModel;

namespace NetflixClone;

public partial class SearchPage : ContentPage
{
    public ObservableCollection<Movie> Movies { get; set; }
    public ObservableCollection<Movie> FilteredMovies { get; set; }

    public SearchPage()
    {
        InitializeComponent();

        // Sample available movies
        Movies = new ObservableCollection<Movie>
            {
                new Movie { Title = "Inception", Category = "Sci-Fi" },
                new Movie { Title = "The Dark Knight", Category = "Action" },
                new Movie { Title = "Forrest Gump", Category = "Drama" },
                new Movie { Title = "The Matrix", Category = "Sci-Fi" },
                new Movie { Title = "Toy Story", Category = "Animation" },
                new Movie { Title = "Avatar", Category = "Sci-Fi" },
                new Movie { Title = "Interstellar", Category = "Sci-Fi" },
                new Movie { Title = "The Lion King", Category = "Animation" }
            };

        FilteredMovies = new ObservableCollection<Movie>(Movies);

        SearchResultsCollectionView.ItemsSource = FilteredMovies;
    }

    private void OnSearchBarTextChanged(object sender, TextChangedEventArgs e)
    {
        var searchTerm = e.NewTextValue.ToLower();
        var filteredResults = Movies.Where(m => m.Title.ToLower().Contains(searchTerm)).ToList();

        FilteredMovies.Clear();
        foreach (var movie in filteredResults)
        {
            FilteredMovies.Add(movie);
        }
    }
}

public class Movie
{
    public string Title { get; set; }
    public string Category
    {
        get; set;
    }
}