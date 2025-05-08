using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CITA355Project2.ViewModel
{
    [QueryProperty("WrongAnswers", "WrongAnswers")]
    [QueryProperty("Grade", "Grade")]
    [QueryProperty("Text", "Text")]
    [QueryProperty("StudentInfo", "StudentInfo")]
    [QueryProperty("GradeText", "GradeText")]
    [QueryProperty("Q1Answer", "Q1Answer")]
    [QueryProperty("Q2Answer", "Q1Answer")]
    [QueryProperty("Q3Answer", "Q3Answer")]
    [QueryProperty("Q5Answer", "Q5Answer")]

    public partial class ResultViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<string> wrongAnswers;
        [ObservableProperty]
        float grade;
        [ObservableProperty]
        string studentInfo;
        //ObservableCollection<string> studentInfo;

        [ObservableProperty]
        string gradeText = "";

        [ObservableProperty]
        string q1Answer;
        [ObservableProperty]
        string q2Answer;
        [ObservableProperty]
        string q3Answer;
        [ObservableProperty]
        string q5Answer;


        [RelayCommand]
        async Task ViewGrades()
        {
            await Shell.Current.GoToAsync($"{nameof(ReportPage)}?Grade=={Grade}&StudentInfo=={StudentInfo}");
        }
    }
}
