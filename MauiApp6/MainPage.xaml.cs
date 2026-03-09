namespace MauiApp6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void checkIfLogged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(emailEntry.Text) && !string.IsNullOrEmpty(passwordEntry.Text))
            {
                loginButton.IsVisible = true;
            }
            else
            {
           loginButton.IsVisible = false;
            }

        }
        private void onSend(object? sender, EventArgs e)
        {
           if(true)
            {
                DisplayAlert("Powiadomienie o zalogowaniu się", "Zalogowałeś się", "OK");
            }
        }
    }
}
