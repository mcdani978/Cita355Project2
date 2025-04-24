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
        [RelayCommand]
        async Task Exam()
        {
            await Shell.Current.GoToAsync($"{nameof(ExamPage)}");
        }
    }
}
