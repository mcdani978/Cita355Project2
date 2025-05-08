using CITA355Project2.ViewModel;
using Microsoft.Extensions.Logging;

namespace CITA355Project2
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainViewModel>();
            builder.Services.AddSingleton<ReportPage>();
            builder.Services.AddSingleton<ReportViewModel>();

            builder.Services.AddTransient<ExamPage>();
            builder.Services.AddTransient<ExamViewModel>();
            builder.Services.AddTransient<ResultPage>();
            builder.Services.AddTransient<ResultViewModel>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
