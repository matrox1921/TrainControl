using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SignalApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            StatusText.Text = "운행중";

            StatusText.Foreground = Brushes.Green;

            SignalLamp.Fill = Brushes.Green;
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            StatusText.Text = "정지";

            StatusText.Foreground = Brushes.Red;

            SignalLamp.Fill = Brushes.Red;
        }

    }
}