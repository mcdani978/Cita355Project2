using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CITA355Project2.ViewModel
{
    [QueryProperty("Grade", "Grade")]
    public partial class ReportViewModel : ObservableObject
    {
        [ObservableProperty]
        float grade;

        [RelayCommand]
        async Task Home()
        {
            await Shell.Current.GoToAsync($"../../..");
        }
    }
}
