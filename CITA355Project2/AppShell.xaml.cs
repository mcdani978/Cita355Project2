namespace CITA355Project2
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ExamPage), typeof(ExamPage));
            Routing.RegisterRoute(nameof(ResultPage), typeof(ResultPage));
            Routing.RegisterRoute(nameof(ReportPage), typeof(ReportPage));
        }
    }
}
