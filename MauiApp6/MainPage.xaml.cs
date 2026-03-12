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
/*
 * nazwa funkcji: checkIfLogged
 * opis funkcji funkcja sprawdza czy email i hasło jest wypełnione i na tej podstawie pokazuje lub ukrywa przycisk logowania
 * parametry : sender - obiekt który wywołał funkcję, e - argumenty zdarzenia
 * zwracany typ i opis brak
 * 
 * nawa funkcji onSend
 * opis funkcji : funkcja wyświetla alert z informacją o zalogowaniu się
 * parametry : sender - obiekt który wywołał funkcję, e - argumenty zdarzenia
 * zwracany typ i opis brak
 */
