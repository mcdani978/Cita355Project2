using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CITA355Project2.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        string text;

        [RelayCommand]
        async Task Exam()
        {
            await Shell.Current.GoToAsync($"{nameof(ExamPage)}");
        }
        [RelayCommand]
        async Task Result()
        {
            await Shell.Current.GoToAsync($"{nameof(ResultPage)}");
        }
        [RelayCommand]
        async Task Report()
        {
            await Shell.Current.GoToAsync($"{nameof(ReportPage)}");
        }
    }
}
