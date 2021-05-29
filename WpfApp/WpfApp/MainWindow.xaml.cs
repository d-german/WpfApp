using System.Windows;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IWeatherService _weatherService;

        public MainWindow(IWeatherService weatherService)
        {
            _weatherService = weatherService;
            InitializeComponent();
            MessageBox.Show(_weatherService.FetchWeatherData().Temperature.ToString());
        }
    }
}
