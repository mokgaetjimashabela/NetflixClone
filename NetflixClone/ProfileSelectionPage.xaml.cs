using System.Collections.ObjectModel;

namespace NetflixClone;

public partial class ProfileSelectionPage : ContentPage
{
    public ObservableCollection<Profile> Profiles { get; set; }

    public ProfileSelectionPage()
    {
        InitializeComponent();

        // Sample profiles
        Profiles = new ObservableCollection<Profile>
            {
                new Profile { Name = "Dineo", Image = "profile1.jpeg" },
                new Profile { Name = "MOkgaetji", Image = "profile2.jpeg" },
                
            };

        ProfilesCollectionView.ItemsSource = Profiles;
    }


    private async void OnProfileTapped(object sender, EventArgs e)
    {
        var tappedProfile = ((TappedEventArgs)e).Parameter as Profile;
        if (tappedProfile != null)
        {
            // Navigate to HomePage
            await Navigation.PushAsync(new HomePage());
        }
    }
}

public class Profile
{
    public string Name { get; set; }
    public string Image { get; set; }
}