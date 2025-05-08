using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CITA355Project2.ViewModel
{
    [QueryProperty("StudentInfo", "StudentInfo")]
    public partial class ReportViewModel : ObservableObject
    {
        public ReportViewModel()
        {
            StudentRecords = new ObservableCollection<string>();
        }

        [ObservableProperty]
        string studentInfo;
        //ObservableCollection<string> studentInfo;

        [ObservableProperty]
        ObservableCollection<string> studentRecords;

        string entry;

        [RelayCommand]
        async Task AddScore()
        {
            if (string.IsNullOrWhiteSpace(StudentInfo))
                return;
            //foreach(string col in Student)
            //{
            //    entry += $"{col} ";
            //}
            entry = studentInfo;
            studentRecords.Add(entry);
            entry = string.Empty;
            studentInfo = string.Empty;
        }

            [RelayCommand]
        async Task Home()
        {
            await Shell.Current.GoToAsync($"../../../../..");
        }
    }
}
