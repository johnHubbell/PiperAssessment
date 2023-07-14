using System.Threading.Tasks;
using System.Windows;

namespace PiperAssessment.Wpf
{
    /// <summary>
    /// Interaction logic for SplashWindow.xaml
    /// </summary>
    public partial class SplashWindow : Window
    {
        public SplashWindow()
        {
            InitializeComponent();
            LoadMainWindow();
        }
        public void LoadMainWindow()
        {
            Task.Factory.StartNew(() =>
            {
                System.Threading.Thread.Sleep(3000);

                Dispatcher.Invoke(() =>
                {
                    var mainWindow = new MainWindow();
                    mainWindow.Show();
                    Close();
                });
            });
        }
    }
}
