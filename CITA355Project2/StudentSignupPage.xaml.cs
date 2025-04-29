namespace CITA355Project2;

public partial class StudentSignupPage : ContentPage
{
	public StudentSignupPage()
	{
		InitializeComponent();
	}

    private void OnSubmitClicked(object sender, EventArgs e)
    {
        string username = usernameEntry.Text;
        string firstName = firstNameEntry.Text;
        string lastName = lastNameEntry.Text;
        string password = passwordEntry.Text;

        // For now, just display the data in an alert
        DisplayAlert("Signup Info", $"Username: {username}\nFirst Name: {firstName}\nLast Name: {lastName}\nPassword: {password}", "OK");
    }
}