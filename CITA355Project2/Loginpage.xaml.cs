namespace CITA355Project2;

public partial class Loginpage : ContentPage
{
	public Loginpage()
	{
		InitializeComponent();
	}

    private async void OnLoginButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new StudentSignupPage());
    }
}