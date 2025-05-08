using CITA355Project2.ViewModel;

namespace CITA355Project2;

public partial class ReportPage : ContentPage
{
	public ReportPage(ReportViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}