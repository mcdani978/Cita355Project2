namespace CITA355Project2;

public partial class StudentSignupPage : ContentPage
{
	public StudentSignupPage()
	{
		InitializeComponent();
	}

    private async void OnSubmitClicked(object sender, EventArgs e)
    {
        string studentID = StudentIDEntry.Text;
        string firstName = firstNameEntry.Text;
        string lastName = lastNameEntry.Text;
        string email = EmailEntry.Text;

        string studentInfo = $"{studentID} {firstName} {lastName} {email}";
        //string[] studentInfo = [studentID, firstName, lastName, email];
        string stuName = $"{firstName} {lastName}";

        //await DisplayAlert("Signup Info",
        //    $"Student ID: {studentID}\nFirst Name: {firstName}\nLast Name: {lastName}\nEmail: {email}",
        //    "OK");

        await Shell.Current.GoToAsync($"{nameof(ExamPage)}?StudentInfo={studentInfo}&StuName={stuName}");
    }
}