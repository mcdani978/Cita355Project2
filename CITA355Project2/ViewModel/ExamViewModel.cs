using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Networking;

namespace CITA355Project2.ViewModel
{
    [QueryProperty("StudentInfo", "StudentInfo")]
    [QueryProperty("StuName", "StuName")]
    public partial class ExamViewModel : ObservableObject
    {
        [ObservableProperty]
        string text;
        [ObservableProperty]
        string q1;
        [ObservableProperty]
        string q2;
        [ObservableProperty]
        string q3;
        [ObservableProperty]
        string q5;
        [ObservableProperty]
        string q1Answer;
        [ObservableProperty]
        string q2Answer;
        [ObservableProperty]
        string q3Answer;
        [ObservableProperty]
        string q5Answer;
        [ObservableProperty]
        float grade;
        [ObservableProperty]
        string gradeText;

        [ObservableProperty]
        string stuName;
        [ObservableProperty]
        string studentInfo;
        //ObservableCollection<string> studentInfo;

        //[ObservableProperty]
        //ObservableCollection<string> wrongAnswers;

        int total = 4, correct = 0;

        [RelayCommand]
        async Task Submit()
        {
            correct = 0;

            if (string.IsNullOrWhiteSpace(Q1))
                return;
            if (Q1 == "Variable")
                correct++;
            Q1Answer = Q1;
            if (string.IsNullOrWhiteSpace(Q2))
                return;
            if (Q2 == "Higher")
                correct++;
            Q2Answer = Q2;
            if (Q3 == "Select an option")
            {
                if (string.IsNullOrWhiteSpace(Q5))
                    return;
            }
            if (Q3 == "Float")
                correct++;
            Q3Answer = Q3;
            if (string.IsNullOrWhiteSpace(Q5))
                return;
            if (Q5 == "False")
                correct++;
            Q5Answer = Q5;
            Grade = (float)(100 * correct / total);
            GradeText = $"You scored: {Grade.ToString()}%";
            StudentInfo += $" | {Grade.ToString()}";
            //StudentInfo.Add(Grade.ToString());

            await Shell.Current.GoToAsync($"{nameof(ResultPage)}?StudentInfo={StudentInfo}" +
                $"&GradeText={GradeText}&Q1Answer={Q1Answer}&Q2Answer={Q2Answer}&Q3Answer={Q3Answer}&Q5Answer={Q5Answer}");

        }
    }
}
