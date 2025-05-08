using CITA355Project2.ViewModel;

namespace CITA355Project2;

public partial class ResultPage : ContentPage
{
	public ResultPage(ResultViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}