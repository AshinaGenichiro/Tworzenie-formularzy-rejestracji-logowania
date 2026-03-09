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