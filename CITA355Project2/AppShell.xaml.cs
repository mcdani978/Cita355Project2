namespace CITA355Project2
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ExamPage), typeof(ExamPage));
        }
    }
}
