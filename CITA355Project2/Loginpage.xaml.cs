namespace CITA355Project2;

public partial class Loginpage : ContentPage
{
    
    private const string PreconfiguredPassword = "1234";

    public Loginpage()
    {
        InitializeComponent();
    }

    private async void OnLoginButtonClicked(object sender, EventArgs e)
    {
        string enteredPassword = passwordEntry.Text;

        if (enteredPassword == PreconfiguredPassword)
        {
            errorLabel.IsVisible = false;
            await Navigation.PushAsync(new StudentSignupPage());
        }
        else
        {
            errorLabel.Text = "Wrong password";
            errorLabel.IsVisible = true;
        }
    }
}