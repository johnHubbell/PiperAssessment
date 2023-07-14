using System.Windows;

namespace PiperAssessment.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool _messageState = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_enter_Click(object sender, RoutedEventArgs e)
        {
            if (_messageState)
            {
                tb_message.Text = "ImagineSoftware is a leading provider of medical billing, revnue cycle, and practice management software";
                btn_enter.Content = "Exit";
                _messageState = false;
            }
            else
            {
                tb_message.Text = "Hit the Enter Key";
                btn_enter.Content = "Enter";
                _messageState = true;
            }
        }
    }
}
