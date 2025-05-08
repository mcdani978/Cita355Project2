using CITA355Project2.ViewModel;

namespace CITA355Project2;

public partial class ExamPage : ContentPage
{
	public ExamPage(ExamViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}