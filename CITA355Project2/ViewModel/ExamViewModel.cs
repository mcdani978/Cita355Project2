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
        ObservableCollection<string> wrongAnswers;
        [ObservableProperty]
        float grade;

        int total = 0, correct = 0;

        [RelayCommand]
        async Task Submit()
        {

            ////if (string.IsNullOrWhiteSpace(Q1))
            ////    return;
            //if (Q1 == "Variable")
            //    correct++;
            //else WrongAnswers.Add("Q1");
            //total++;
            ////if (string.IsNullOrWhiteSpace(Q2))
            ////    return;
            //if (Q2 == "Higher")
            //    correct++;
            //else WrongAnswers.Add("Q2");
            //total++;
            ////if (string.IsNullOrWhiteSpace(Q3) || Q3 == "Select an option")
            ////    return;
            //if (Q3 == "Float")
            //    correct++;
            //else WrongAnswers.Add("Q3");
            //total++;
            ////if (string.IsNullOrWhiteSpace(Q5))
            ////    return;
            //if (Q5 == "False")
            //    correct++;
            //else WrongAnswers.Add("Q5");
            //total++;
            //Grade = correct / total;
            Text = Q1;

            await Shell.Current.GoToAsync($"{nameof(ResultPage)}?WrongAnswers=={WrongAnswers}&Grade=={Grade}&Text=={Text}");

        }
    }
}
