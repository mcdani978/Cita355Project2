using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CITA355Project2.ViewModel
{
    public partial class ExamViewModel : ObservableObject
    {
        [RelayCommand]
        async Task Submit()
        {
            if ()
            await Shell.Current.GoToAsync($"{nameof(ResultPage)}");
        }
    }
}
