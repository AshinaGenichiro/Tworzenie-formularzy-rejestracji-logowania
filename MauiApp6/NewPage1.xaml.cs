namespace MauiApp6;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}
	private void isCheckBoxChecked(object? sender, EventArgs e)
	{
		if (AcceptCheckBox.IsChecked)
		{
            RegisterButton.IsVisible = true;
		}
		else
		{
         RegisterButton.IsVisible = false;
        }
    }
	private void register(object ? sender, EventArgs e)
	{
		DisplayAlertAsync("Powiadomienie o rejestracji", "Zarejestrowałeś się", "OK");
    }

}
/*
 * 
 * nazwa funckji ischeckBoxChecked
 * opis funkcji : funkcja sprawdza czy checkbox jest zaznaczony, jeśli tak to pokazuje przycisk rejestracji, jeśli nie to go ukrywa
 * parametry : sender - obiekt który wywołał funkcję, e - argumenty zdarzenia
 * zwracany typ i opis brak
 * 
 * nazwa funkcji: register
 * opis funkcji : funkcja wyświetla alert z informacją o rejestracji
 * parametry : sender - obiekt który wywołał funkcję, e - argumenty zdarzenia
 * zwracany typ i opis brak
 * 
 * 
 */
 
