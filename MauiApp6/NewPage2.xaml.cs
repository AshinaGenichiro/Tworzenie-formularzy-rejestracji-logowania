namespace MauiApp6;

public partial class NewPage2 : ContentPage
{
	public NewPage2()
	{
		InitializeComponent();
	}
	private void setPriorityPicker(object sender, System.EventArgs e)
	{
		PriorityPicker.IsEnabled = true;
        if (subjectPicker.SelectedIndex == 0)
		{
            PriorityPicker.ItemsSource = new List<string> { "Niski", "Średni","Wysoki" };
        }
        else if (subjectPicker.SelectedIndex == 2)
		{
            PriorityPicker.ItemsSource = new List<string> { "Niski", "Średni" };
        }
        else
        {
            PriorityPicker.IsEnabled = false;
        }
	}
    private void checkIfCorrectAndSend(object sender, System.EventArgs e)
    {

        if (!string.IsNullOrEmpty(NameEntry.Text) && !string.IsNullOrEmpty(EmailEntry.Text) && subjectPicker.SelectedIndex >=0  && !string.IsNullOrEmpty(MessageEditor.Text))
        {
            if (PriorityPicker.SelectedIndex == 0 && PriorityPicker.SelectedIndex == 2)
            {

                DisplayAlertAsync("Powiadomienie o wysłaniu wiadomości", $"Wiadomość została Imię: {NameEntry.Text}, Email: {EmailEntry.Text}, Wybrany temat: {subjectPicker.Items[subjectPicker.SelectedIndex]},Priorytet: {PriorityPicker.Items[PriorityPicker.SelectedIndex]}, Wiadomość: {MessageEditor.Text} ", "OK");
            }
            else
            {
                DisplayAlertAsync("Powiadomienie o wysłaniu wiadomości", $"Wiadomość została Imię: {NameEntry.Text}, Email: {EmailEntry.Text}, Wybrany temat: {subjectPicker.Items[subjectPicker.SelectedIndex]}, Wiadomość: {MessageEditor.Text} ", "OK");

            }
        }
        else
        {
              DisplayAlertAsync("Błąd", "Proszę wypełnić wszystkie pola", "OK");
        }
    }
}
/*
 * Nazwa funkcji : setPriorityPicker
 * opis funkcji : Funkcja sprawdza jaki jest wybrany temat i na tej podstawie ustala dostępne priorytety do wyboru
 * parametry : sender - obiekt który wywołał funkcję, e - argumenty zdarzenia
 * zwracany typ i opis brak
 * 
 * nazwa funkcji : checkIfCorrectAndSend
 * opis funckji : funkcja sprawdza czy pola są wypełnione oraz wypisuje je w alrecie, jeśli priorytet jest dostępny to również go wypisuje
 *  parametry : sender - obiekt który wywołał funkcję, e - argumenty zdarzenia
 *  zwracany typ i opis brak
 * 
 * 
 */
