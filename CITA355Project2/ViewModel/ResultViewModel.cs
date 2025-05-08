using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CITA355Project2.ViewModel
{
    [QueryProperty("WrongAnswers", "WrongAnswers")]
    [QueryProperty("Grade", "Grade")]
    [QueryProperty("Text", "Text")]

    public partial class ResultViewModel : ObservableObject
    {
        [ObservableProperty]
        string text;
        [ObservableProperty]
        ObservableCollection<string> wrongAnswers;
        [ObservableProperty]
        float grade;

        [RelayCommand]
        async Task ViewGrades()
        {
            await Shell.Current.GoToAsync($"{nameof(ReportPage)}?Grade=={Grade}");
        }
    }
}
